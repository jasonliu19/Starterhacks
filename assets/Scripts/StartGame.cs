using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void GotoMenuScene()
    {
        SceneManager.LoadScene("map1");
    }
}