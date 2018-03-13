
using UnityEngine;

public class BulletFly : MonoBehaviour {

    public float speed = 10;


    public float lifeTime = 10;
    private float _startTime;


    // Use this for initialization
    void Start () {
        _startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Time.time - _startTime > lifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}
