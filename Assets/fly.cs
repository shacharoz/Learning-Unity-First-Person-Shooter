using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    public float Speed = 20;
    
    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
