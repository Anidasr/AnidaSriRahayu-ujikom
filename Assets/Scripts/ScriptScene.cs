using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene : MonoBehaviour
{
  public void PindahScene (string sceneName)
    {
        SceneManager.LoadScene (sceneName);
    }
}
