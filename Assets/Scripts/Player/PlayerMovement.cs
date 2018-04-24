using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class PlayerMovement : MonoBehaviour {

        public float Speed;
        public float LookSpeed;

        new Transform transform;

        private void Awake () {
            transform = GetComponent<Transform> ();
        }

        private void Update () {
            var input = new Vector3 (
                Input.GetAxis ("Horizontal"),
                0f,
                Input.GetAxis ("Vertical")
                );

            if (input.sqrMagnitude > 1)
                input.Normalize ();

            var dt = Time.deltaTime;

            // TODO:
            // Improve the target lookat rotation to be less jerky.
            // Can be done with lerping or whatever.

            transform.SetPositionAndRotation (
                transform.position + transform.TransformDirection (Speed * dt * input),
                transform.rotation * Quaternion.Euler (0, Input.GetAxis ("Mouse X") * LookSpeed * dt, 0)
                );
                
        }

    }

}