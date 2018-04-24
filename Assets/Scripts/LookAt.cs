using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class LookAt : MonoBehaviour {

        public Transform Target;
        public Vector3 Offset;

        new Transform transform;

        private void Awake () {
            transform = GetComponent<Transform> ();
        }

        // Update is called once per frame
        void Update () {
            transform.LookAt (Target.position + Target.TransformDirection (Offset));
        }
    }

}