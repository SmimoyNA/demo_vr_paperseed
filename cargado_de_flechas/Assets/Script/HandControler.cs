using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControler : MonoBehaviour
{

	public float movHorizontal;
	public float movVertical;
	public CharacterController handLeft;
	public float speedMove;



	void Start()
    {
		handLeft = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
		movHorizontal = Input.GetAxis("Horizontal");
		movVertical = Input.GetAxis("Vertical");

		handLeft.Move(new Vector3(movHorizontal, 0, movVertical) * speedMove * Time.deltaTime);
	}

	private void FixedUpdate()
	{ 

	}

}
