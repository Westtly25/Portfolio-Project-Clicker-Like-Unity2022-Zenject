using System;

namespace Assets.Code.Scripts.Runtime.State_Machine
{
    public abstract class State
    {
        public bool IsActive { get; set; }

        public State()
        {
            
        }

        public virtual void OnEnter() { }
        public virtual void OnRun() { }
        public virtual void OnExit() { }
    }
}
