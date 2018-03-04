using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void GotoMenuScene()
    {
        print("Button pressed");
        SceneManager.LoadScene("map1");
    }
}