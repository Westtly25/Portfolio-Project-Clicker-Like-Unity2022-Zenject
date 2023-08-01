using Zenject;
using Assets.Code.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.Pause;
using Assets.Code.Scripts.Runtime.State_Machine.Gameplay_State_Machine;

namespace Assets.Code.Scripts.Runtime.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameplayStateMachine>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.Bind<PlayerScore>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<PauseHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();
        }
    }
}
