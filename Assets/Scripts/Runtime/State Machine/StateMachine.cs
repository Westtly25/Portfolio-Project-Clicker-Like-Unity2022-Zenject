using System;
using System.Collections.Generic;

namespace Assets.Code.Scripts.Runtime.State_Machine
{
    public class StateMachine
    {
        public bool TransitionsEnabled { get; set; } = true;
        public bool HasCurrentState { get; private set; }

        public State CurrentState { get; private set; }
        public Transition CurrentTransition { get; private set; }

        private readonly HashSet<State> currentStates = new(5);
        private readonly List<Transition> anyTransitions = new(5);
        private readonly List<Transition> transitions = new(5);

        private bool isStatesAdded;

        public StateMachine()
        {
        }

        public StateMachine(params State[] states)
        {
            AddStates(states);
        }

        public void AddStates(params State[] states)
        {
            if (isStatesAdded)
                throw new Exception("States already added!");

            foreach (var state in states)
            {
                if (state == null)
                {
                    throw new NullReferenceException(nameof(state));
                }

                currentStates.Add(state);
            }

            if (states.Length > 0)
                isStatesAdded = true;
        }

        public void SetState<TState>() where TState : State =>
            SetState(typeof(TState));

        public void AddTransition<TStateFrom, TStateTo>(Func<bool> condition)
            where TStateFrom : State
            where TStateTo : State
        {
            var stateFrom = GetState(typeof(TStateFrom));
            var stateTo = GetState(typeof(TStateTo));

            transitions.Add(new Transition(stateFrom, stateTo, condition));
        }

        public void AddAnyTransition<TStateTo>(Func<bool> condition)
            where TStateTo : State
        {
            var stateTo = GetState(typeof(TStateTo));

            anyTransitions.Add(new Transition(null, stateTo, condition));
        }

        public virtual void Run()
        {
            if (TransitionsEnabled)
                SetStateByTransitions();

            if (HasCurrentState)
                CurrentState.OnRun();
        }

        public void SetStateByTransitions()
        {
            CurrentTransition = GetTransition();

            if (CurrentTransition == null)
                return;

            if (CurrentState == CurrentTransition.To)
                return;

            SetState(CurrentTransition.To.GetType());
        }

        public TState GetState<TState>() where TState : State =>
            (TState)GetState(typeof(TState));

        private State GetState(Type type)
        {
            foreach (var state in currentStates)
            {
                if (state.GetType() == type)
                    return state;
            }

            throw new Exception($"The <{type.Name}> is not found!");
        }

        private void SetState(Type type)
        {
            if (HasCurrentState)
                ExitCurrentState();

            CurrentState = GetState(type);
            HasCurrentState = true;

            EnterCurrentState();
        }

        private void EnterCurrentState()
        {
            CurrentState.IsActive = true;
            CurrentState.OnEnter();
        }

        private void ExitCurrentState()
        {
            CurrentState.IsActive = false;
            CurrentState.OnExit();
        }

        private Transition GetTransition()
        {
            for (var i = 0; i < anyTransitions.Count; i++)
            {
                if (anyTransitions[i].Condition())
                {
                    return anyTransitions[i];
                }
            }

            for (var i = 0; i < transitions.Count; i++)
            {
                if (transitions[i].From.IsActive == false)
                {
                    continue;
                }

                if (transitions[i].Condition())
                {
                    return transitions[i];
                }
            }

            return default;
        }
    }
}