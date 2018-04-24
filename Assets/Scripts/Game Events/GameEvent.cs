using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Game Event")]
    public class GameEvent : ScriptableObject {

        List<GameEventListener> activeListeners = new List<GameEventListener> ();

        public GameObject Raiser { get; private set; }

        public void AddListener (GameEventListener listener) {
            activeListeners.Add (listener);
        }

        public void RemoveListener (GameEventListener listener) {
            activeListeners.Remove (listener);
        }

        public void Raise () {
            for (var i = activeListeners.Count - 1; i >= 0; i--) {
                activeListeners[i].OnEventRaised ();
            }
        }

        public void RaiseWithSource (GameObject source) {
            Raiser = source;
            Raise ();
            Raiser = null;
        }

        /*
        public void RaiseDeffered () {

        }
        */
    }

}