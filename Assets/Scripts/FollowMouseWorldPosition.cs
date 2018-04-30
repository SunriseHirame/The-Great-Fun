using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class FollowMouseWorldPosition : MonoBehaviour {

        public LayerMask Layers;

        new Transform transform;
        Camera mainCamera;

        private void Start () {
            transform = GetComponent<Transform> ();
            mainCamera = Camera.main;
        }

        void Update () {
            var ray = mainCamera.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit, 100f, Layers))
                transform.position = hit.point;
            else
                transform.position = mainCamera.transform.position + ray.direction * 1000f;
        }
    }

}