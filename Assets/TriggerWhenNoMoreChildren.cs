using UnityEngine;
using UnityEngine.Events;

public class TriggerWhenNoMoreChildren : MonoBehaviour {

    public UnityEvent NoMoreChildren;

    private bool triggeredOnce;

	// Use this for initialization
	void Start () {
        triggeredOnce = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if (!triggeredOnce && transform.childCount == 0)
        {
            NoMoreChildren.Invoke();
            triggeredOnce = true;
        }
	}
}
