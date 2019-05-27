using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorNavMesh : MonoBehaviour
{

	public float ejex;
	public float ejey;
	public float ejez;

	[HideInInspector]
	public Transform perseguirObjetivo;

	private UnityEngine.AI.NavMeshAgent nmAgent;




    void Awake()
    {
		nmAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

	public void ActualizarDestinoNMA(Vector3 puntoDestino)
	{
		//nmAgent.isStopped = true;
		nmAgent.destination = puntoDestino;
		nmAgent.isStopped = false;

		ejex = puntoDestino.x;
		ejey = puntoDestino.y;
		ejez = puntoDestino.z;

    }

	public void DetenerNMA()
	{
		nmAgent.isStopped = true;
	}

	public bool colisionDestinoNMA()
	{
		return nmAgent.remainingDistance <= nmAgent.stoppingDistance && !nmAgent.pathPending;
	}
}
