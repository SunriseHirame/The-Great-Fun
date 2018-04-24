using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class Gun : MonoBehaviour {

        public Vector3 BulletSpawnOffset;

        public GameObject ClipPrefab;
        public Rigidbody BulletPrefab;
        public Rigidbody Casing;

        public float BulletSpeed = 50;
        public float Deviation = 3f;

        public Vector3 ShotOrigin => transform.position + transform.TransformVector (BulletSpawnOffset);

        public void Fire () {
            var bullet = Instantiate (
                BulletPrefab,
                ShotOrigin,
                transform.rotation * Quaternion.Euler (Random.insideUnitSphere * Deviation));

            bullet.velocity = bullet.transform.forward * BulletSpeed;
            bullet.useGravity = true;
            bullet.isKinematic = false;

            var casing = Instantiate (
                Casing,
                transform.position + transform.right * 0.2f,
                transform.rotation
                );

            casing.velocity = transform.right * 5f + Vector3.up;
            casing.useGravity = true;
            casing.isKinematic = false;
        }

        private void Update () {
            if (Input.GetKeyDown (KeyCode.Mouse0))
                Fire ();
        }

        private void OnDrawGizmosSelected () {
            var dir = transform.TransformVector (BulletSpawnOffset);
            var origin = transform.position + dir;

            Gizmos.color = Color.yellow;
            Gizmos.DrawRay (origin, dir);
            Gizmos.DrawCube (origin, new Vector3 (0.1f, 0.1f, 0.1f));
        }

    }

}