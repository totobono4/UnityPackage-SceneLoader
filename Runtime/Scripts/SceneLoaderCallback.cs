using UnityEngine;

namespace Totobono4.SceneLoader {
    public class SceneLoaderCallback : MonoBehaviour {
        private bool isFisrtUpdate = true;

        private void Update() {
            if (!isFisrtUpdate) return;

            isFisrtUpdate = false;
            SceneLoaderCore.LoaderCallback();
        }
    }
}