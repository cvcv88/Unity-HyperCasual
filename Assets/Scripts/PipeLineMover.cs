using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLineMover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

	// ��� 2
	private void Start()
	{
		Destroy(gameObject, 10);
	}
	private void Update()
	{
		transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

		// ��� 1
		/* if(transform.position.x < -10)
		{
			Destroy(gameObject);
		}*/
	}
}
