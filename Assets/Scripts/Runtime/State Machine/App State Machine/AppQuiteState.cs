using UnityEngine;
using Assets.Code.Scripts.Runtime.State_Machine;

public class AppQuiteState : State
{
    public override void OnEnter()
    {
        base.OnEnter();

        Application.Quit();
    }
}