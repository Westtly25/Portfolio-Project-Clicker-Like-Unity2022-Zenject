using UnityEngine;
using Assets.Code.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.State_Machine;

public class AppSaveProgressState : State
{
    private readonly SaveHandler saveHandler;

    public AppSaveProgressState(SaveHandler saveHandler) =>
        this.saveHandler = saveHandler;

    public override void OnEnter()
    {
        base.OnEnter();

        saveHandler.Save();
    }
}
