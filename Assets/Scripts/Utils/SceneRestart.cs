using UnityEngine;
using UnityEngine.SceneManagement;

namespace Runner.Utils
{
    public class SceneRestart : MonoBehaviour
    {
        private Scene _currentScene;

        private void Awake()
        {
            _currentScene = SceneManager.GetActiveScene();
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(_currentScene.buildIndex);
        }
    }
}
