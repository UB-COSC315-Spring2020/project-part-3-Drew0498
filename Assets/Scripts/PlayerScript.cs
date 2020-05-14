using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
      public TextMeshProUGUI PlayerHealthText;
      public int PlayerHealth = 3;
      public Rigidbody rb; // Refrence for player rigidbody
      public float speed = 6.0F;
      public float jumpSpeed = 8.0F;
      public float gravity = 20F;
      private Vector3 moveDirection = Vector3.zero;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    
    }
    // Update is called once per frame
    void Update()
    {


        PlayerHealthText.text = "Life: " + PlayerHealth.ToString();

        rb.drag = 1000;
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
           //Movement
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
           
            moveDirection *= speed;
           // Checking for Jump
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

            
           
        }

         
        
        //Gravity
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            PlayerHealth--;
            Debug.Log("PLAYER COLLISION");

        }


        if (PlayerHealth < 1)
        {

            SceneManager.LoadScene("LoseScene");

        }

        /*
        if (other.gameObject.tag == "BulletTrigger")
        {
          //FindObjectOfType<EnemyShootingLeft>().StartShooting();
            Debug.Log("ShootingStarted");

        }

    }
    */
    }
}
