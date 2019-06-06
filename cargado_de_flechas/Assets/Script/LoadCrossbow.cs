using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCrossbow : MonoBehaviour
{

	public MonoBehaviour VC;
	public GameObject ArrowPrefab;
	private GameObject arrowChargered;
	public Transform arrowPosition;
	private Rigidbody rb;
	public bool arrowInHand;
	public bool handInXbow = false;
	public bool arrowInXbow = false;
	public float speed = 30f;

	private void Update()
	{
		
		if (Input.GetKeyDown(KeyCode.H) && arrowInXbow)
		{
			rb = arrowChargered.GetComponent<Rigidbody>();

			rb.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

			rb.useGravity = true;

			arrowChargered.transform.SetParent(null);

		}

	}

	private void OnTriggerEnter(Collider other)
	{
		arrowInHand = VC.GetComponent<VirtualCarcajScript>().arrowInHand;

		if (other.tag == "ArrowPicker" && !handInXbow && arrowInHand)
		{
			handInXbow = true;

			if (!arrowInXbow)
			{
				GameObject arrowHand = GameObject.FindWithTag("Arrow");
				Destroy(arrowHand);
				arrowInHand = false;
				arrowChargered = Instantiate(ArrowPrefab);
				arrowChargered.transform.SetParent(arrowPosition);
				arrowChargered.transform.position = arrowPosition.position;
				arrowChargered.transform.rotation = arrowPosition.rotation;
				arrowInXbow = true;
			}

		}

	}

	private void OnTriggerExit(Collider other)
	{
		handInXbow = false;
	}
}
