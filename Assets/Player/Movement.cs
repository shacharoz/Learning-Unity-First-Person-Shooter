
using UnityEngine;

public class Movement : MonoBehaviour {

    public float _speed;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        //controlling the player up and down, left and right
        Move();

    }



    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }
    }
 }
