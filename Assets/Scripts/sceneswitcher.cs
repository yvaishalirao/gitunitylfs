using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
