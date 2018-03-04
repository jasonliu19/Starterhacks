using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public void GoToLevel(string level)
    {
        Application.LoadLevel(level);
    }
}