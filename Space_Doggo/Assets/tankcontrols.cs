using UnityEngine;
using System.Collections.Generic;

public class tankcontrols : MonoBehaviour {

	private Transform tf;
	private Rigidbody2D rb2D;
	public float turnSpeed;
	public float moveSpeed;

	public float force;

	private float angle = 0.0f;


	void Start()
	{
		tf = GetComponent<Transform>();
		rb2D = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.A))
			{
				angle += turnSpeed * Time.deltaTime;
				tf.rotation = Quaternion.Euler(0, 0, angle);
			}

		if (Input.GetKey(KeyCode.D))
			{
				angle -= turnSpeed * Time.deltaTime;
				tf.rotation = Quaternion.Euler(0, 0, angle);
			}

		if (Input.GetKey(KeyCode.W))
			{
				tf.Translate(tf.up * moveSpeed * Time.deltaTime, Space.World);
				//tf.position += (tf.right * moveSpeed * Time.deltaTime);
				//tf.position += (tf.TransformDirection(Vector3.right) * moveSpeed * Trans
			}
		
		if (Input.GetKey(KeyCode.S))
			{
					tf.Translate(-tf.up * moveSpeed * Time.deltaTime, Space.World);
					//tf.position -= (tf.right * moveSpeed * Time.deltaTime);
					//tf.position -= (tf.TransormDirection(Vector3.right) * moveSpeed * Trans
			}

	}
}