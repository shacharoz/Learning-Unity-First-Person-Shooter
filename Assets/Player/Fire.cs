using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public Transform Gun;
    public Transform BulletParent;
    public GameObject BulletPrefab;

    public GameObject RocketPrefab;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireNow();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireNowRocket();
        }
    }

    private void FireNow()
    {
        Instantiate(BulletPrefab, Gun.transform.position,Gun.transform.rotation, BulletParent);
        Gun.GetComponent<AudioSource>().Play();
    }

    private void FireNowRocket()
    {
        Instantiate(RocketPrefab, Gun.transform.position, Gun.transform.rotation, BulletParent);
        Gun.GetComponent<AudioSource>().Play();
    }
}
