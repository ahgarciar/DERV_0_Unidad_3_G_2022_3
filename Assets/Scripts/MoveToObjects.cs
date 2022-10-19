using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObjects : MonoBehaviour
{
    [SerializeField]
    GameObject objDestino;

    [SerializeField]
    float velocidad;

    Vector3 currentVelocity = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }    

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position; //Gameobject que contenga al script
        Vector3 destino = objDestino.transform.position;

        destino.x -= 2;  //destino.x = destino.x - 2; 
        destino.z -= 2;

        destino.y = origen.y;
        /*
        if (origen.x>destino.x)
        {

        }
        */

        //move towards
        //transform.position = Vector3.MoveTowards(origen, destino, velocidad * Time.deltaTime);

        //lerp
        //transform.position = Vector3.Lerp(origen, destino, velocidad * Time.deltaTime);

        //smoothdamp        
        transform.position = Vector3.SmoothDamp(origen, destino, ref currentVelocity, velocidad * Time.deltaTime);

    }
}
