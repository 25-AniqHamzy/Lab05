using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerProperties : MonoBehaviour
{
    public GameObject collectedUI;

    int coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coins += 10;
            Destroy(other.gameObject);
            collectedUI.GetComponent<Text>().text = "Coin Collected : " + coins; 

            if(coins >= 100)
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
