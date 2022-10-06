using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShow : MonoBehaviour
{
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;


        print("" + UnityStandardAssets.Characters.FirstPerson.MouseLook.m_cursorIsLocked);
    }
}
