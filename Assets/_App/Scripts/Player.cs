using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
	float speed = 10f;

	void HandleMovement()
	{
		if (isLocalPlayer)
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");
			Vector3 movement = new Vector3(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime, 0f);
			transform.position = transform.position + movement;
		}
	}

	void Update()
	{
		HandleMovement();
	}
}
