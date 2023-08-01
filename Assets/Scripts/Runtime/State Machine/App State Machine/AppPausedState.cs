using Assets.Code.Scripts.Runtime.Pause;
using Assets.Code.Scripts.Runtime.State_Machine;

public class AppPausedState : State
{
    private readonly PauseHandler pauseHandler;

    public AppPausedState(PauseHandler pauseHandler) =>
        this.pauseHandler = pauseHandler;

    public override void OnEnter()
    {
        base.OnEnter();

        pauseHandler.SetPaused(true);
    }

    public override void OnExit()
    {
        base.OnExit();

        pauseHandler.SetPaused(false);
    }
}