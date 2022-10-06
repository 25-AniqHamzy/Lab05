using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void OnRetry()
    {
        SceneManager.LoadScene("GameScene");
    }
}
