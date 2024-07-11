using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celda : MonoBehaviour
{
    Quaternion siguienteRotacion;
    float velocidadRotacion = 20;
    bool noPuedeRotar;

    bool mouseEncima;

    private void Awake()
    {
        siguienteRotacion = transform.rotation;
    }



    private void OnMouseOver()
    {
        // mouse encima del collider
        mouseEncima = true;
    }

    private void OnMouseExit()
    {
        // mouse salio del collider
        mouseEncima = false;
    }

    private void Update()
    {

        if(mouseEncima)
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (noPuedeRotar) return;

                Vector3 angulos = transform.localEulerAngles;
                angulos.y += 180;
                siguienteRotacion.eulerAngles = angulos;
                noPuedeRotar = true;
                Invoke("SiPuedeRotar", 0.4f);
            }

            if(Input.GetMouseButtonDown(1))
            {
                if (noPuedeRotar) return;

                Vector3 angulos = transform.localEulerAngles;
                angulos.x += 180;
                siguienteRotacion.eulerAngles = angulos;
                noPuedeRotar = true;
                Invoke("SiPuedeRotar", 0.4f);
            }

            if(Input.GetMouseButtonDown(2))
            {
                print("EL BOTON DEL MEDIO");
                Vector3 mp = Input.mousePosition;
                mp.z = Camera.main.transform.position.z;

                Vector3 wmp = Camera.main.ScreenToWorldPoint(mp);
                offset = transform.position - wmp;
                agarrado = true;
            }

            if (agarrado)
            {
                Vector3 mp = Input.mousePosition;
                mp.z = Camera.main.transform.position.z;

                Vector3 wmp = Camera.main.ScreenToWorldPoint(mp);
                transform.position = wmp + offset;

                if(Input.GetMouseButtonUp(2))
                {
                    agarrado = false;
                }
            }

        }

        transform.rotation = Quaternion.Lerp(transform.rotation, siguienteRotacion, velocidadRotacion * Time.deltaTime );
    }

    void SiPuedeRotar()
    {
        noPuedeRotar = false;
    }



    // ACA VA EL DRAG N DROP


    Vector3 offset;
    bool agarrado;


    private void OnMouseDrag()
    {


    }

    private void OnMouseUp()
    {
        agarrado = false;
    }
}
