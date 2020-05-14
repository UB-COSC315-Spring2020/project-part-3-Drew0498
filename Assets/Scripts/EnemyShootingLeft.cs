using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingLeft : MonoBehaviour
{

    public GameObject BulletE;
    public float Speed = 100f;
    public float TimeBeforeShoot;
    public float Timer;
    public bool CheckIftriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        StartShooting();

    }
   
    

    void StartShooting()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {



            GameObject instBullet = Instantiate(BulletE, transform.position, Quaternion.identity) as GameObject;
            Rigidbody InstBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            InstBulletRigidbody.AddForce(Vector3.left * Speed);

            Timer = 3.5f;
        }
    }



}
