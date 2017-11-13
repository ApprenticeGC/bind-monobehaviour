using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMH.Demo
{
    public class AudioManager : MonoBehaviour
    {
        [Zenject.Inject]
        public void Construct()
        {

        }

        public void PlayAudioClip()
        {
            Debug.Log("Play Audio Clip");
        }
    }
}

