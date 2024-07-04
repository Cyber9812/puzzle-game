using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSimple: MonoBehaviour
{
    // Velocidad de rotaci�n del objeto
    public float rotationSpeed = 100f;

    // Update se llama una vez por frame
    void Update()
    {
        // Verifica si el bot�n izquierdo del rat�n est� siendo presionado
        if (Input.GetMouseButton(0))
        {
            // Rotar a la izquierda
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // Verifica si el bot�n derecho del rat�n est� siendo presionado
        if (Input.GetMouseButton(1))
        {
            // Rotar a la derecha
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
