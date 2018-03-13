using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public Transform Gun;
    public Transform BulletParent;
    public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireNow();
        }

    }

    private void FireNow()
    {
        Instantiate(BulletPrefab, Gun.transform.position,Gun.transform.rotation, BulletParent);
      
    }
}
