using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCrossbow : MonoBehaviour
{

	public MonoBehaviour VC;
	public bool handInXbow = false;
	public bool arrowInXbow = false;
	public Transform arrowPosition;
	public bool arrowInHand;



	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "ArrowPicker" && !handInXbow && VC.GetComponent<VirtualCarcajScript>().ArrowInHand)
		{
			handInXbow = true;

			if (!arrowInXbow)
			{
				GameObject arrow = GameObject.Find("ARROW");
				arrow.transform.SetParent(arrowPosition);
				arrow.transform.position = arrowPosition.position;
				arrow.transform.rotation = arrowPosition.rotation;
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
