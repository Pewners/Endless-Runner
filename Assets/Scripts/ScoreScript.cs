using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public Transform player;
	public Text scoreText;
	public int score;

    void Start() 
    {
		
    }
	
	void Update () 
	{
		scoreText.text = score.ToString();
	}
}