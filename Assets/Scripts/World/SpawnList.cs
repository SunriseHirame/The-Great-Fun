using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/World/Spawn List")]
    public class SpawnList : ScriptableObject {

        public int WeightTotal;
        public SpawnEntry[] Spawnables;

        public Transform GetRandomSpawnable () {
            return Spawnables[0].Object;
        }
        
    }

}