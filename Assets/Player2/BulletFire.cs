using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

    public float _speed;

    public float lifetime = 5;
    private float firsttime;


    // Use this for initialization
    void Start () {
        firsttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime *_speed);
        if ( Time.time - firsttime > lifetime)
        {
            Destroy(this.gameObject);
        }
        



    }
}
