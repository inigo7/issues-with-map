using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteraction : MonoBehaviour
{
//public GameObject lever;
//public float nearLever = 6f;
public List<GameObject> colliderList = new List<GameObject>();

     public void OnTriggerEnter(Collider collider)
     {
         if (!colliderList.Contains(collider.gameObject))
         {
             colliderList.Add(collider.gameObject);
             Debug.Log("Added " + gameObject.name);
             Debug.Log("GameObjects in list: " + colliderList.Count);
         }
     }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    /*if (Vector3.Distance (Object1.tranform.position, Object2.tranform.position) < 100)
        {
        //Do something because the distance is less than 100
        }
        if (Input.GetKeyCode(KeyCode.E))
        {

        }*/
    }
}
