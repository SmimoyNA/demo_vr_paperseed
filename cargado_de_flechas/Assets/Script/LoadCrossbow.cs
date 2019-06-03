using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCrossbow : MonoBehaviour
{

	public MonoBehaviour VC;
	public bool handInXbow = false;
	public bool arrowInXbow = false;
	public Transform arrowPosition;


	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "ArrowPicker" && !handInXbow && VC.GetComponent<VirtualCarcajScript>().ArrowInHand)
		{
			handInXbow = true;

			if (!arrowInXbow)
			{
				GameObject arrow = GameObject.FindWithTag("Arrow");
				arrow.transform.SetParent(arrowPosition);
				arrow.transform.position = arrowPosition.position;
				arrowInXbow = true;

				VC.GetComponent<VirtualCarcajScript>().ArrowInHand = false;
			}

		}

	}

	private void OnTriggerExit(Collider other)
	{
		handInXbow = false;
	}
}
