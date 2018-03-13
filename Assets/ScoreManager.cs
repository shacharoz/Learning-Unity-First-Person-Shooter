using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private int _score;

    public int ShootingTargetScore = 100;

    public int Score()
    {
        return _score;
    }

    public void UpdateScore(int addition)
    {
        _score += addition;
    }

    public void HitShootingTarget()
    {
        UpdateScore(ShootingTargetScore);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
