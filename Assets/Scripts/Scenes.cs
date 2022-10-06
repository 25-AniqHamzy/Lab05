using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void OnRetry()
    {
        SceneManager.LoadScene("GameScene");
        //UnityStandardAssets.Characters.FirstPerson.MouseLook.m_cursorIsLocked = true;
    }
}
