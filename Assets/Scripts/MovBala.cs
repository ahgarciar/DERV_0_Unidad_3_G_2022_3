using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]
    float velocidad; // se inicializan en el inspector

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.forward * velocidad, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
