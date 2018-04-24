using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class RotateAround : MonoBehaviour {

        public Vector3 AxisMask;
        public float Speed;
        public Transform Center;

        [SerializeField, HideInInspector]
        new Transform transform;

        private void Awake () {
            AxisMask.Normalize ();
        }

        private void Update () {
            transform.RotateAround (Center.position, AxisMask, Speed * Time.deltaTime);
        }

        private void Reset () {
            transform = GetComponent<Transform> ();
        }

    }

}