using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    
    public void changeMenuScene(string scenename)
    {
        print("Button was pressed");
        Application.LoadLevel(scenename);
    }
}