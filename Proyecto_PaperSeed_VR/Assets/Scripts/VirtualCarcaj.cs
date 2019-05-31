using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCarcaj : MonoBehaviour
{
	public bool handInCarcaj = false;
	public GameObject Arrow;
	public Transform spawPoint;
	public bool ArrowExist = false;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "ArrowPicker" && !handInCarcaj)
		{
			handInCarcaj = true;
		}

		if (other.tag == "ArrowPicker" && !ArrowExist)
		{
			handInCarcaj = true;
			Instantiate(Arrow, spawPoint.position, new Quaternion(0,0,0,0));
			Arrow.transform.position = new Vector3(1, 0, 0);
			ArrowExist = true;
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
