using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public Transform GunShaft;
    public KeyCode KeyForBullet = KeyCode.Space;
    public GameObject BulletPrefab;

    private Transform BulletParent;

    private KeyCode KeyForRocket = KeyCode.Alpha1;
    private GameObject RocketPrefab;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyForBullet))
        {
            FireNow();
        }

        if (Input.GetKeyDown(KeyForRocket))
        {
            FireNowRocket();
        }
    }

    private void FireNow()
    {
        Instantiate(BulletPrefab, GunShaft.transform.position,GunShaft.transform.rotation, BulletParent);
        GunShaft.GetComponent<AudioSource>().Play();
    }

    private void FireNowRocket()
    {
        Instantiate(RocketPrefab, GunShaft.transform.position, GunShaft.transform.rotation, BulletParent);
        GunShaft.GetComponent<AudioSource>().Play();
    }
}
