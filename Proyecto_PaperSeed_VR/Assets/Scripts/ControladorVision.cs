using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVision : MonoBehaviour
{
	public Transform vision;
	public float rangoVision = 20f;
	public Vector3 offset = new Vector3(0f, 0.7f, 0f);

	private ControladorNavMesh controladorNavMesh;
	

	void Awake()
    {
		controladorNavMesh = GetComponent<ControladorNavMesh>();
    }

	

	public bool VisionAlPlayer(out RaycastHit Hit, bool miraPlayer = false)
	{
		Vector3 vectorDireccion;

		if (miraPlayer)
		{
			vectorDireccion = (controladorNavMesh.perseguirObjetivo.position + offset) - vision.position;
		}
		else
		{
			vectorDireccion = vision.forward;
		}

		return Physics.Raycast(vision.position, vectorDireccion, out Hit, rangoVision) && Hit.collider.CompareTag("Player") ;
	}
}
