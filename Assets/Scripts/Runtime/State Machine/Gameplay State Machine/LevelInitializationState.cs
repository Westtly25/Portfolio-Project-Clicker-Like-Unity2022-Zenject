using Assets.Code.Scripts.Runtime.Data;

namespace Assets.Code.Scripts.Runtime.State_Machine.Board_State_Machine
{
    public class LevelInitializationState : State
    {
        private readonly PlayerScore score;

        public LevelInitializationState(PlayerScore playerScore)
        {
            this.score = playerScore;
        }

        public override void OnEnter()
        {
            base.OnEnter();
        }

        public override void OnExit()
        {
            base.OnExit();
        }
    }
}
