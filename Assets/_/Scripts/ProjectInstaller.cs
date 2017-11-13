using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMH.Demo
{
    public class ProjectInstaller : Zenject.MonoInstaller
    {
        [System.Serializable]
        public class Settings
        {
            public GameObject audioManagerPrefab;
        }

        public Settings settings;

        public override void InstallBindings()
        {
            Container.Bind<Settings>().FromInstance(settings).AsSingle();
            //Container.BindInterfacesAndSelfTo<SceneManager>().AsSingle();

            Container
                .Bind<AudioManager>()
                .FromComponentInNewPrefab(settings.audioManagerPrefab)
                .AsSingle()
                .NonLazy();
        }
    }
}
