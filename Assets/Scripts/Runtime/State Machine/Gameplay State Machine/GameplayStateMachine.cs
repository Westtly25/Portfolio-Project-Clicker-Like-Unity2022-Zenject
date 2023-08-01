using Zenject;
using Assets.Code.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.Pause;

namespace Assets.Code.Scripts.Runtime.State_Machine.Gameplay_State_Machine
{
    public class GameplayStateMachine : StateMachine, IPauseListener
    {
        private readonly PauseHandler pauseHandler;

        private bool isPaused = false;

        [Inject]
        public GameplayStateMachine(PlayerScore playerScore,
                                    PauseHandler pauseHandler)
        {
            this.pauseHandler = pauseHandler;

            State[] states =
            {
            };

            AddStates(states);
        }

        public override void Run()
        {
            if (isPaused)
                return;

            base.Run();
        }

        public void Pause(bool isPaused) =>
            this.isPaused = isPaused;
    }
}