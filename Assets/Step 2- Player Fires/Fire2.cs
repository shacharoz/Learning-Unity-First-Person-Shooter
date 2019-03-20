using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire2 : MonoBehaviour {
    
    // Use this for initialization
	void Start () {
		
	}


    public GameObject bulletPrefab;
    public Transform gunLocation;


    public Vector3 OriginalKingPosition;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //fire a bullet from the gun location (prefab)
            Instantiate(bulletPrefab, gunLocation.position, gunLocation.rotation);

            //make sound
            if (gunLocation.GetComponent<AudioSource>()) gunLocation.GetComponent<AudioSource>().Play();
            
        }
        
	}
}
