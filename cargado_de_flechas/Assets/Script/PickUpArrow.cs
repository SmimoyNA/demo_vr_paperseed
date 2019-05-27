using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpArrow : MonoBehaviour
{

	public GameObject ArrowToPickUp;
	public GameObject PickerArrow;
	public Transform InteractionZone;
	
	
    void Update()
    {/*
		if (ArrowToPickUp != null && ArrowToPickUp.GetComponent<ArrowControler>().isPickable == true && PickerArrow == null)
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				PickerArrow = ArrowToPickUp;
				PickerArrow.GetComponent<ArrowControler>().isPickable = false;
				PickerArrow.transform.parent = this.gameObject.transform;
				PickerArrow.transform.position = InteractionZone.position;
				PickerArrow.GetComponent<Rigidbody>().isKinematic = true;
			}
		}*/
    }
}
