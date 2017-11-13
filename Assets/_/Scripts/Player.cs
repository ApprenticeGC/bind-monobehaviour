using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMH.Demo
{
    public class Player : MonoBehaviour
    {
        [Zenject.Inject]
        public void Construct(AudioManager audioManager)
        {
            audioManager.PlayAudioClip();
        }
    }
}

