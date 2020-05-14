using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingleft : MonoBehaviour
{
    public GameObject Enemy;
    public int EnemeyHealth = 4;
    public ParticleSystem Splatter;
    public ParticleSystem Gun;
    public Gradient ParticleColorGrad;
    List<ParticleCollisionEvent> collisonEvents;
    // Start is called before the first frame update
    void Start()
    {
        collisonEvents = new List<ParticleCollisionEvent>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ParticlePhysicsExtensions.GetCollisionEvents(Gun, other, collisonEvents);
        for (int i = 0; i < collisonEvents.Count; i++)
        {
            EmitatLocation(collisonEvents[i]);
        }

    }

    void EmitatLocation(ParticleCollisionEvent particleCollisionEvent)
    {
        Splatter.transform.position = particleCollisionEvent.intersection;
        Splatter.transform.rotation = Quaternion.LookRotation(particleCollisionEvent.normal);
        ParticleSystem.MainModule psMain = Splatter.main;
        psMain.startColor = ParticleColorGrad.Evaluate(Random.Range(0f, 1f));


        Splatter.Emit(1);
    }
    void EnemyDamage(ParticleCollisionEvent EnemeyHit)
    {
        if (gameObject.CompareTag("Enemy"))
        {
            EnemeyHealth--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          

            Gun.Emit(1);
        }

    }

}
