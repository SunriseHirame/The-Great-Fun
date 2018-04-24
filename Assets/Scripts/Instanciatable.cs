using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Instanciatable")]
    public class Instanciatable : ScriptableObject {

        public GameObject Prefab;

        public int MaxChildCount = 1;

        public void InstanciateAsChild (Transform transform) {
            if (transform.childCount >= MaxChildCount)
                return;

            var p = Instantiate (Prefab, transform.position, transform.rotation, transform);
            p.SetActive (true);
        }
    }

}