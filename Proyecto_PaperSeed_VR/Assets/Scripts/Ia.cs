using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ia : MonoBehaviour
{

    public float tiempo;
    public float Speed;
    float y;
    float smooth= 5f; 
    bool tiempoGiro;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        tiempo += Time.deltaTime;
        transform.Translate(-transform.forward * Speed * Time.deltaTime);

        if(tiempo >= 3f)
        {
            Girar();
            tiempo = 0;
            tiempoGiro = true;

        }

        if(tiempoGiro == true)
        {
            if(tiempo >= 3f)
            {
                //y = 0;
                tiempoGiro = false;
            }
        }

    }

    public void Girar()
    {
        y = Random.Range(-150, 150);
        //transform.Rotate()

         Quaternion target = Quaternion.Euler(0, y, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }

}
