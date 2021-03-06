﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Hirame {

    public class Timer : MonoBehaviour {

        public float Delay = 1;
        public bool Repeat;
        public bool StartOnEnable;

        public UnityEvent OnTimerFinished;

        public void OnEnable () {
            if (StartOnEnable)
                Invoke ("RaiseEvent", Delay);
        }

        void RaiseEvent () {
            OnTimerFinished.Invoke ();

            if (Repeat)
                Invoke ("RaiseEvent", Delay);
        }
        
    }

}
