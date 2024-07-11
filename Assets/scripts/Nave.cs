using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float minX, maxX, minY, maxY;

    public bool puedeControlarNave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(puedeControlarNave)
        {
            SerguirMouse();
        }
        LimitarDesplazamiento();
    }

    void SerguirMouse()
    {
        Vector3 mp = Input.mousePosition;
        mp.z = Camera.main.transform.position.z;

        Vector3 wmp = Camera.main.ScreenToWorldPoint(mp);
        wmp.z = 0;
        transform.position = wmp;// + offset;
    }

    void LimitarDesplazamiento()
    {
        Vector3 posicionNave = transform.position;
        posicionNave.x = Mathf.Clamp(posicionNave.x, minX, maxX);
        posicionNave.y = Mathf.Clamp(posicionNave.y, minY, maxY); 
        
        transform.position = posicionNave;
    }
}
