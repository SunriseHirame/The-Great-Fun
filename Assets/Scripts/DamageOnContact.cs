using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class DamageOnContact : MonoBehaviour {

        public float Damage;
        public Faction TargetFaction;
        public bool DestroyIfValidTarget = true;

        private void OnCollisionEnter (Collision collision) {
            DamageTarget (collision.rigidbody?.GetComponent<Actor> ());
        }

        private void OnTriggerEnter (Collider other) {
            DamageTarget (other.attachedRigidbody?.GetComponent<Actor> ());
        }

        void DamageTarget (Actor actor) {
            if (actor == null)
                return;

            if (TargetFaction != null && !actor.ActorFaction.Equals (TargetFaction))
                return;
                
            var health = actor.Health;
            if (health == null)
                return;
            health.Current -= Damage;

            if (DestroyIfValidTarget)
                Destroy (gameObject);
        }
    }

}
