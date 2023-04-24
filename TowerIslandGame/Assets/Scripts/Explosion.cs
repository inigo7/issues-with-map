using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float delay = 3f;
    public float radius = 5f;
    public float force = 500f;

    public GameObject explosionEffect;
    public AudioSource audioSource;

    float countdown;
    bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
        //change delay to 500f for "press f to detonate"
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
            audioSource.Play();
        }
        
        //uncomment lines 37-40 for detonate button
        /*if (Input.GetKeyDown(KeyCode.F))
        {
            countdown = delay;
        }*/
    }
    void Explode()
    {
        //Debug.Log("explosion!");
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
        
        Destroy(gameObject);
        
    }
}
