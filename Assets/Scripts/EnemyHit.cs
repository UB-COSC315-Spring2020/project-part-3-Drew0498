using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EnemyHit : MonoBehaviour
{


  
    public int EnemeyH = 3;
   
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckifEzOrHard();
    }
    // Different enemy type's health 
    void CheckifEzOrHard()
    {
        if (gameObject.tag == "Kill Ez")
        {
            EnemeyH = 1;
        }


   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kill"))
        {

            EnemeyH--;

            Debug.Log("Collision");
        }

        



        if (EnemeyH < 1)
        {

            DestroyEnemy();


        }

        if (other.gameObject.tag == "Kill Ez")
        {
          
            EnemeyH--;



            if (EnemeyH < 1)
            {

                DestroyEnemy();




            }



        }

       
    }

   public void DestroyEnemy()
    {
        Destroy(gameObject);

        FindObjectOfType<ScoreScript>().AddtoScore();
    }


}




