using UnityEngine;

public class PlayerCollision : MonoBehaviour{
	
	public PlayerController movement;

	void OnCollisionEnter2D (Collision2D collisionInfo)
	{
		Debug.Log (collisionInfo.gameObject.tag);
		if (collisionInfo.collider.tag == "CleanUp")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().GameOver();
		}
	}
}