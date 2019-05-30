using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCrossbow : MonoBehaviour
{

	public MonoBehaviour VC;
	public bool handInXbow = false;


	private void OnTriggerEnter(Collider other)
	{

		handInXbow = true;

		if (other.tag == "ArrowPicker" && !handInXbow)
		{
			handInXbow = true;

			GameObject arrow = GameObject.FindWithTag("Arrow");

			arrow.transform.SetParent(this.transform);

			VC.GetComponent<VirtualCarcajScript>().ArrowInHand = false;
		}

	}
}
