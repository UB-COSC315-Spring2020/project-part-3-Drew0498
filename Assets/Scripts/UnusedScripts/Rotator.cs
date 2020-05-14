using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float flipvalue;
    public GameObject Gun;
    public Vector3  Curpos;
    public Vector3 StartPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
        
        TurnMethod();

        Curpos = transform.position;
        Debug.Log(Curpos);

    }
    void TurnMethod()
    {

     
        if (Input.GetKeyDown(KeyCode.A))
        {
            Gun.transform.Rotate(0, 180, 0);
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Gun.transform.Rotate(0, -180, 0);
        }

           
    }

    

         


}
