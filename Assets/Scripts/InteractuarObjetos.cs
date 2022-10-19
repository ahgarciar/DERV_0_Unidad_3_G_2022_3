using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarObjetos : MonoBehaviour
{
    [SerializeField]
    Transform origen_rayo;

    [SerializeField]
    Transform ubicacion_objeto_tomado;

    Vector3 origen; //objeto que tiene el script
    Vector3 direccion_rayo;

    float distancia_rayo = 2f;

    [SerializeField]
    bool tomado;
    string nombre_objeto_tomado;

    // Start is called before the first frame update
    void Start()
    {
        tomado = false;
        direccion_rayo = origen_rayo.forward; //
    }

    // Update is called once per frame
    void Update()
    {
        origen = origen_rayo.position; //se calcula siempre debido a que el personaje se mueve
        origen.y -= 0.25f;                               //

        RaycastHit hit; //Almacena informacion de la colision. Consultar: https://docs.unity3d.com/ScriptReference/RaycastHit.html

        if (Physics.Raycast(origen, direccion_rayo, out hit, distancia_rayo))
        {
            //hit.   <- para extrar informacion del objeto con el que se colisiono 
            Debug.DrawRay(origen, direccion_rayo * hit.distance, Color.yellow); //para hacer visible al rayo

            if (Input.GetKeyDown(KeyCode.G))
            {
                nombre_objeto_tomado = hit.collider.gameObject.name;
                GameObject temp = GameObject.Find(nombre_objeto_tomado);

                temp.transform.SetParent(ubicacion_objeto_tomado); //lo añade a la jerarquia
                temp.GetComponent<Rigidbody>().useGravity = false; //quita la gravedad para que no se caiga
                temp.GetComponent<Rigidbody>().isKinematic = true;
                temp.transform.position = ubicacion_objeto_tomado.position;
                temp.transform.rotation = ubicacion_objeto_tomado.rotation;
                tomado = true;
                Debug.Log("Choca con Objeto");
            }

        }
        else
        {
            Debug.DrawRay(origen, direccion_rayo * distancia_rayo, Color.red); //hace visible un rayo (alcance de vision)

            if (tomado) { //tomado == true
                if (Input.GetKeyDown(KeyCode.G)) {
                    GameObject temp = GameObject.Find(nombre_objeto_tomado);

                    temp.transform.SetParent(null); //lo quita de la jerarquia
                    temp.GetComponent<Rigidbody>().useGravity = true; //
                    temp.GetComponent<Rigidbody>().isKinematic = false;
                    //temp.transform.position = ubicacion_objeto_tomado.position;
                    //temp.transform.rotation = ubicacion_objeto_tomado.rotation;
                    tomado = false;
                    Debug.Log("Choca con Objeto");
                }
            }

        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(ubicacion_objeto_tomado.position, Vector3.one);
        //Vector3.one => new Vector3(1,1,1)
    }

}


