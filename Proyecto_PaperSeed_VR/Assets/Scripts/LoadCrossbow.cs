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
	public Rigidbody puntaFlecha;
	public SphereCollider sp;
	public bool arrowInHand;
	public bool handInXbow = false;
	public bool arrowInXbow = false;
	public float speed = 25f;



	private void Update()
	{

		if (Input.GetKeyDown(KeyCode.H) && arrowInXbow)
		{
			puntaFlecha = GameObject.FindWithTag("puntaFlecha").GetComponent<Rigidbody>();

			arrowChargered.transform.SetParent(null);

			rb = arrowChargered.GetComponent<Rigidbody>();

			rb.useGravity = true;

			puntaFlecha.useGravity = true;

			rb.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

			arrowInXbow = false;

		}

	}


	private void OnTriggerEnter(Collider other)
	{
		;

		if (other.tag == "ArrowPicker" && VC.GetComponent<VirtualCarcajScript>().ArrowInHand)
		{
			handInXbow = true;

			if (!arrowInXbow)
			{
				GameObject arrowDestroy = GameObject.Find("ARROW(Clone)");
				Destroy(arrowDestroy);
				VC.GetComponent<VirtualCarcajScript>().ArrowInHand = false;
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
