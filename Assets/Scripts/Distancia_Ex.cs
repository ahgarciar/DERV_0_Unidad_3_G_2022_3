using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distancia_Ex : MonoBehaviour
{
    [SerializeField]
    Transform origen;
    [SerializeField]
    Transform destino;

    [SerializeField]
    Vector3 origen_vector3;
    [SerializeField]
    Vector3 destino_vector3;

    public float distancia;

    // Start is called before the first frame update
    void Start()
    {
        //origen_vector3 = origen.position;
        //destino_vector3 = destino.position;
    }

    // Update is called once per frame
    void Update()
    {
        origen_vector3 = origen.position;
        destino_vector3 = destino.position;

        distancia = Vector3.Distance(origen_vector3, destino_vector3);
    }
}
