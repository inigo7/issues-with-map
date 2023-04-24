using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombSpawn : MonoBehaviour
{

    public GameObject bomb;
    public float placeForce = 5f;
    public float bombCount = 5f;
    public Text Bombs;
    public static int BombsCount;


    public void OnTriggerEnter(Collider Col)
	{
		if(Col.gameObject.tag == "BombCoin")
		{
			Debug.Log("bombcoi work");
			bombCount += 1f;
            BombsCount += 1;
			Col.gameObject.SetActive(false);
			Destroy(Col.gameObject);
			//coinSound.Play();
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        BombsCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Bombs.text = "Bombs left: " + BombsCount;
        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bomb, transform.position, transform.rotation);
            bombCount -= 1f;
        }*/
        if (bombCount > 0f)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
            //Instantiate(bomb, transform.position, transform.rotation);
            ThrowBomb();
            bombCount -= 1f;
            BombsCount -= 1;
            }
        }
        void ThrowBomb()
        {
            GameObject Explosive = Instantiate(bomb, transform.position, transform.rotation);
            Rigidbody rb = Explosive.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * placeForce, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            bombCount += 1f;
            BombsCount += 1;
        }
    }
    /*	public void OnTriggerEnter(Collider Col)
	{
		if(Col.gameObject.tag == "Bomb")
		{
			Debug.Log("bomb collecyasdf");
			BombsCount += 1;
            bombCount += 1f;
			Col.gameObject.SetActive(false);
			Destroy(Col.gameObject);
			//coinSound.Play();
		}
	}*/
}
