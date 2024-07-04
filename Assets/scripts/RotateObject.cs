using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Velocidad de rotaci�n del objeto
    public float rotationSpeed = 100f;
    // Indica si el objeto est� en modo rotaci�n en el eje Y
    private bool isYAxisRotation = false;
    // Referencia al objeto espec�fico a rotar
    public GameObject targetObject;

    void Update()
    {
        // Verifica si el bot�n de la rueda del rat�n fue presionado
        if (Input.GetMouseButtonDown(2))
        {
            // Cambiar el modo de rotaci�n al eje Y
            isYAxisRotation = !isYAxisRotation;
        }

        // Detectar clic en el objeto
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Verificar si el objeto clicado es el objeto asignado
                if (hit.transform.gameObject == targetObject)
                {
                    Debug.Log("Se hizo clic en el objeto: " + targetObject.name); // Agregar mensaje de debug
                    RotateSelectedObject();
                }
            }
        }
    }

    void RotateSelectedObject()
    {
        if (isYAxisRotation)
        {
            // Verifica si el bot�n izquierdo del rat�n est� siendo presionado
            if (Input.GetMouseButton(0))
            {
                // Rotar en el eje Y hacia la izquierda
                targetObject.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            }

            // Verifica si el bot�n derecho del rat�n est� siendo presionado
            if (Input.GetMouseButton(1))
            {
                // Rotar en el eje Y hacia la derecha
                targetObject.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }
        else
        {
            // Verifica si el bot�n izquierdo del rat�n est� siendo presionado
            if (Input.GetMouseButton(0))
            {
                // Rotar en el eje X hacia la izquierda
                targetObject.transform.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime);
            }

            // Verifica si el bot�n derecho del rat�n est� siendo presionado
            if (Input.GetMouseButton(1))
            {
                // Rotar en el eje X hacia la derecha
                targetObject.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
