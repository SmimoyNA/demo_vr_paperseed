using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPatrulla : MonoBehaviour
{

	public Transform[] wayPoints;

	public float ejex;
	public float ejey;
	public float ejez;

	private ControladorNavMesh controladorNavMesh;
	private int nextWayPoint;

    void Awake()
    {
		controladorNavMesh = GetComponent<ControladorNavMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	void OnEnable()
	{
		controladorNavMesh.ActualizarDestinoNMA(wayPoints[nextWayPoint].position);
		ejex = wayPoints[nextWayPoint].position.x;
		ejey = wayPoints[nextWayPoint].position.y;
		ejez = wayPoints[nextWayPoint].position.z;
	}


}
