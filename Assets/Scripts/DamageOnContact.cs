using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class DamageOnContact : MonoBehaviour {

        public float Damage;

        private void OnCollisionEnter (Collision collision) {
           // TODO:
           // FUCKING DO IT RIGHT
            var health = collision.rigidbody?.GetComponent<Actor> ()?.Health;
            if (health == null)
                return;
            health.Current -= Damage;
        }

        private void OnTriggerEnter (Collider other) {
            var health = other.attachedRigidbody?.GetComponent<Actor> ()?.Health;
            if (health == null)
                return;
            health.Current -= Damage;
        }
    }

}
