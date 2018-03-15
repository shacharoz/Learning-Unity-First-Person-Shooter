using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour {


    public Transform Gun;
    public GameObject bulletPrefab;

   
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            FireNow();
        }
	}

    private void FireNow()
    {
        Instantiate(bulletPrefab,Gun.position,Gun.rotation);
    }
}
