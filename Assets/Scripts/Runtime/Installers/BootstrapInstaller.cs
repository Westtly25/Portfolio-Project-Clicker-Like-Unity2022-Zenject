using Zenject;
using Assets.Code.Scripts.Runtime.Utilities;
using Assets.Code.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.Audio_System;
using Assets.Code.Scripts.Runtime.Input_System;
using Assets.Code.Scripts.Runtime.Asset_Management;

namespace Assets.Code.Scripts.Runtime.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<AssetProvider>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<AudioService>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<SaveHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<CoroutineRunner>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<Logger>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<FileHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<InputService>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();
        }
    }
}