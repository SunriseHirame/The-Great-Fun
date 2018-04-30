using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public abstract class GlobalValue<T> : ScriptableObject {

        [System.Flags]
        public enum ValueResetMode : byte { OnEnable = 1, OnDisable = 2, Both = 3 }

        public ValueResetMode ResetMode = ValueResetMode.Both;

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

        private void OnEnable () {
            if (ResetMode.HasFlag (ValueResetMode.OnEnable))
                value = default (T);
        }

        private void OnDisable () {
            if (ResetMode.HasFlag (ValueResetMode.OnDisable))
                value = default (T);
        }
    }

}