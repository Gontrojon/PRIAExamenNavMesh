using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // variable para controlar el indice del click con valores minimo 0 y maximo 1
    [Range(0, 1)]
    public int mouseButtonIndex = 0;


    void Update()
    {
        // cuando se pulsa el boton del raton
        if (Input.GetMouseButtonDown(mouseButtonIndex))
        {
            // se hace un raycast desde la camara a la posicion del raton
            RaycastHit hitData;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitData, 1000))
            {
                // se asigna el lugar del click como posicion de la meta
                Vector3 newposition = hitData.point;
                newposition.y = 1;
                transform.position = newposition;
            }
        }
    }
}
