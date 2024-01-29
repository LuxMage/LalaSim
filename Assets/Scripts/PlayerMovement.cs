using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	#region Public Serialized Properties

	public float Speed;

	#endregion

	#region Private Properties

	private CharacterController charController;

	#endregion

	#region Unity Messages

	// Start is called before the first frame update
	void Start()
	{
		charController = gameObject.GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update()
	{
		float zMove = Input.GetAxis("Vertical");
		float xMove = Input.GetAxis("Horizontal");

		charController.Move(new Vector3(xMove * Speed, 0.0f, zMove * Speed));
	}

	#endregion
}
