using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class LevelGenerator : MonoBehaviour {

        public bool GenerateOnStart;

        public int LevelSizeX = 4;
        public int LevelSizeZ = 4;

        public Transform BasePiece;
        public Vector3 BasePieceSize = new Vector3 (10, 1, 10);

        public UnityEngine.AI.NavMeshSurface NavMesh;

        public GameEvent LevelGenerationStarted;
        public GameEvent LevelGenerationDone;

        public Transform[] LevelPieces;


        Quaternion[] rotations = new Quaternion[] {
            Quaternion.Euler (0, 0 ,0),
            Quaternion.Euler (0, 90, 0),
            Quaternion.Euler (0, 180, 0),
            Quaternion.Euler (0, -90, 0)
        };

        public bool IsLevelGenerated { get; private set; }

        private void Start () {
            if (GenerateOnStart) {
                GenerateLevel ();
            }
        }

        public void GenerateLevel () {
            if (IsLevelGenerated)
                ClearLevel ();

            LevelGenerationStarted?.Raise ();

            BasePiece.gameObject.SetActive (true);

            var numPieces = LevelPieces.Length;
            var numRotations = rotations.Length;

            var origin = transform.position;
            for (var x = -LevelSizeX; x <= LevelSizeX; x++) {
                for (var z = -LevelSizeZ; z <= LevelSizeZ; z++) {
                    var pos = origin + new Vector3 (x * BasePieceSize.x, 0, z * BasePieceSize.z);
                    Instantiate (BasePiece, pos, Quaternion.identity, transform);

                    if ((x == 0 && z == 0) || LevelPieces?.Length == 0)
                        continue;

                    var p = Instantiate (
                        LevelPieces[Random.Range (0, numPieces)],
                        pos,
                        rotations[Random.Range (0, numRotations)],
                        transform
                        );

                    p.gameObject.SetActive (true);
                }
            }
            BasePiece.gameObject.SetActive (false);
            NavMesh?.BuildNavMesh ();
            LevelGenerationDone.Raise ();
        }

        public void ClearLevel () {
            Debug.Log ("Existing Level Cleared");
        }

        IEnumerator DoLevelGeneration () {
            Debug.Log ("Level Generated");
            yield return null;
        }
    }

}