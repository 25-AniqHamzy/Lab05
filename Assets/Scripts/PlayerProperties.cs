using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerProperties : MonoBehaviour
{
    public GameObject collectedUI,TimerUI;

    int coins;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        timer = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        TimerUI.GetComponent<Text>().text = "Timer : " + timer.ToString("F2") + " ( 20 seconds )";
    }

    private void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coins += 10;
            Destroy(other.gameObject);
            collectedUI.GetComponent<Text>().text = "Coin Collected : " + coins; 

            if(coins >= 60)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}
