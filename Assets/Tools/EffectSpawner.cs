using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSpawner : MonoBehaviour {

    public GameObject EffectPrefabToSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnNow()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
        Vector3 pos = transform.position - new Vector3(0,0,transform.localScale.z);
        Instantiate(EffectPrefabToSpawn, transform.position, transform.rotation);
        
    }
}
