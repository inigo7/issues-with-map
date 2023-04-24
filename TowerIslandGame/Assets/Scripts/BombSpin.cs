using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
		transform.Rotate (55 * Time.deltaTime, 90 * Time.deltaTime, 66 * Time.deltaTime);
        }
        /*{
        transform.Translate()
        }*/
    }
}
