using UnityEngine;
using System.Collections;

public class Movescript : MonoBehaviour
{
	public Vector2 speed = new Vector2 (100, 100);
	public Vector2 direction = new Vector2(-1,0);

	private Vector2 mouvement;

	void Update()
	{
		mouvement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = mouvement * Time.deltaTime;
	}
}