using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	Rigidbody arrowBody;
	private float lifeTimer = 2f;
	private float timer;
	private bool hitSomething = false;

	void Start()
    {

		arrowBody = GetComponent<Rigidbody>();

    }



	void Update()
    {

		transform.rotation = Quaternion.LookRotation(arrowBody.velocity);

    }
}
