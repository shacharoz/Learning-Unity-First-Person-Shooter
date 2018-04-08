using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionManager : MonoBehaviour {

    public string ShootingTargetTagName = "ShootingTarget";

    private GameObject _player;

    public UnityEngine.Events.UnityEvent OnHit;

    // Use this for initialization
    void Start () {
        _player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ShootingTargetTagName)
        {
            OnHit.Invoke();

            _player.GetComponent<ScoreManager>().HitShootingTarget();

            Destroy(this.gameObject);

            other.gameObject.GetComponent<KillAfter>().KillNow();

        }   
    }
}
