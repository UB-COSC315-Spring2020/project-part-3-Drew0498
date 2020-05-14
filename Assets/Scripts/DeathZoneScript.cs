using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeathZone")
        {
            SceneManager.LoadScene("LoseScene");
        }

        if (other.gameObject.tag == "Win")
        {
            SceneManager.LoadScene("WinScene");
        } 
    }
}
