using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public abstract class GlobalValue<T> : ScriptableObject {

        [SerializeField]
        protected T value;

        public T GetValue () {
            return value;
        }

        public string GetValueAsString () {
            return value.ToString ();
        }

        public override string ToString () {
            return $"{typeof(T)} - {value.ToString ()}";
        }
    }

}