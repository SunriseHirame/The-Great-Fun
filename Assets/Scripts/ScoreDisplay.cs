using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Hirame {

    public class ScoreDisplay : MonoBehaviour {

        public Text text;
        public GlobalInt EnemiesLeft;
        int previousEnemyCount;

        public GameEvent LelvelCleared;

        private void Update () {
            var enemies = EnemiesLeft.GetValue ();
            if (previousEnemyCount != enemies) {
                previousEnemyCount = enemies;
                UpdateText ();

                if (enemies == 0) {
                    LelvelCleared?.Raise ();
                    enabled = false;
                }
            }
        }

        void UpdateText () {
            text.text = EnemiesLeft.GetValueAsString ();
        }
    }

}