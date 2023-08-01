using Assets.Code.Runtime.Data;
using Assets.Code.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.State_Machine;

namespace Assets.Code.Scripts.Runtime.State_Machine.Board_State_Machine
{
    public class LevelInitializationState : State
    {
        private readonly PlayerScore score;
        private readonly LevelData level;

        public LevelInitializationState(PlayerScore playerScore,
                                        LevelData level)
        {
            this.score = playerScore;
            this.level = level;
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
