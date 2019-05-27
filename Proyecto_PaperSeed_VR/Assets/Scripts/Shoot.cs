using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public Camera cam;
	public GameObject arrowPrefab;
	public Transform arrowSpawn;
	public float shootForce = 20f;


	void Start()
    {
        
    }


	void Update()
    {
        
		if (Input.GetMouseButton(0))
		{
			GameObject go = Instantiate(arrowPrefab, arrowSpawn.position, Quaternion.identity);
			Rigidbody rb = go.GetComponent<Rigidbody>();
			rb.velocity = cam.transform.forward * shootForce;

		}

    }
}
