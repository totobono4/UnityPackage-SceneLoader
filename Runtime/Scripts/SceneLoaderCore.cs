using UnityEngine.SceneManagement;

namespace Totobono4.SceneLoader {
    public static class SceneLoaderCore {
        public enum Scene {
            MainMenuScene,
            LoadingScene,
            CreditScene,
            GameScene
        }

        private static string targetScene;

        public static void Load(Scene targetScene) {
            Load(targetScene.ToString(), Scene.LoadingScene.ToString());
        }

        public static void Load(string targetScene) {
            Load(targetScene, Scene.LoadingScene.ToString());
        }

        public static void Load(Scene targetScene, string loadingScene) {
            Load(targetScene.ToString(), loadingScene);
        }

        public static void Load(string targetScene, Scene loadingScene) {
            Load(targetScene, loadingScene.ToString());
        }

        public static void Load(Scene targetScene, Scene loadingScene) {
            Load(targetScene.ToString(), loadingScene.ToString());
        }

        public static void Load(string targetScene, string loadingScene) {
            SceneLoaderCore.targetScene = targetScene;
            SceneManager.LoadScene(loadingScene);
        }

        public static void LoaderCallback() {
            if (targetScene == null) return;
            SceneManager.LoadScene(targetScene);
            targetScene = null;
        }
    }
}