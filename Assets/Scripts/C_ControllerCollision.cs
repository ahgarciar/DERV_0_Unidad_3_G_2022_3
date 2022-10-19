using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_ControllerCollision : MonoBehaviour
{
    //NOTA!!!!!
    //NO FUNCIONAL CUANDO SE TRABAJA CON CHARACTER CONTROLLERS
    ///


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra en colision");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Permanece en colision");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sale de colision");
    }

}
