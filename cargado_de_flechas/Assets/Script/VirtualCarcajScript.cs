using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCarcajScript : MonoBehaviour
{
	public bool handInCarcaj = false;
	public GameObject ArrowPrefab;
	public Transform arrowPicker;
	public bool ArrowInHand = false;
	private GameObject Arrow;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "ArrowPicker" && !handInCarcaj)
		{
			handInCarcaj = true;
		}

		if (other.tag == "ArrowPicker" && !ArrowInHand)
		{
			handInCarcaj = true;
			Arrow = Instantiate(ArrowPrefab, arrowPicker.position, new Quaternion(0,0,0,0));
			Arrow.transform.SetParent(other.transform);
			ArrowInHand = true;

		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "ArrowPicker" && handInCarcaj)
		{
			handInCarcaj = false;
		}
	}
}
