using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
   
    public GameObject BulletR;
    public GameObject BulletL;
    public float Speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(1))
        {
            GameObject instBullet = Instantiate(BulletR, transform.position, Quaternion.identity) as GameObject;
            Rigidbody InstBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            InstBulletRigidbody.AddForce(Vector3.right * Speed);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject instBullet = Instantiate(BulletL, transform.position, Quaternion.identity) as GameObject;
            Rigidbody InstBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            InstBulletRigidbody.AddForce(Vector3.left * Speed);
        }
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            Debug.Log("LayerDetect");
            Destroy(other.gameObject);
        }
    }

}



