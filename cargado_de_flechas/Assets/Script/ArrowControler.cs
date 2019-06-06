using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControler : MonoBehaviour
{
	public bool isPickable = true;
	public bool handInArrow = false;
	public GameObject arrow;

	private void OnTriggerEnter(Collider other)
	{
		handInArrow = true;

		if(other.tag == "ArrowPicker")
		{
		}
	}
}
