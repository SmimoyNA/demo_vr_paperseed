using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCarcajScript : MonoBehaviour
{

	private GameObject Arrow;
	public GameObject ArrowPrefab;
	public GameObject Crossbow;
	public Transform arrowPicker;
	public bool arrowInHand = false;
	public bool handInCarcaj = false;
	public int contArrow = 0;


	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "ArrowPicker" && !handInCarcaj)
		{
			handInCarcaj = true;
		}

		if (other.tag == "ArrowPicker" && !arrowInHand)
		{
			handInCarcaj = true;
			Arrow = Instantiate(ArrowPrefab);
			Arrow.transform.SetParent(other.transform);
			Arrow.transform.position = other.transform.position;
			arrowInHand = true;
			contArrow++;

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
