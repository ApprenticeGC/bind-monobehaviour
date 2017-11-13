using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMH.Demo
{
    public class SceneInstaller : Zenject.MonoInstaller
    {
        [System.Serializable]
        public class Settings
        {

        }

        public Settings settings;

        public override void InstallBindings()
        {
            Container.Bind<Settings>().FromInstance(settings).AsSingle();
            Container.BindInterfacesAndSelfTo<SceneManager>().AsSingle();
        }
    }
}
