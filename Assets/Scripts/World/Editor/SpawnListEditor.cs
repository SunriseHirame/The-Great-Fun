#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Hirame.Editor {

    [CustomEditor (typeof (SpawnList))]
    public class SpawnListEditor : UnityEditor.Editor {

        SpawnList spawnList;

        private void OnEnable () {
            spawnList = target as SpawnList;
        }

        public override void OnInspectorGUI () {
            UpdateValues ();
            base.OnInspectorGUI ();
        }

        void UpdateValues () {
            var total = 0;
            var spawnables = spawnList.Spawnables;
            var l = spawnables.Length;

            for (var i = 0; i < l; i++) {
                var weight = spawnables[i].Weight;
                if (weight < 0)
                    spawnables[i].Weight = weight = 0;
                total += weight;
            }
            spawnList.WeightTotal = total;

            for (var i = 0; i < l; i++) {
               spawnables[i].Percent = (float) spawnables[i].Weight / total;
            }
        }
    }
}

#endif