using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_CharacterController : MonoBehaviour
{
    [SerializeField]
    CharacterController cc;

    [SerializeField]
    float velocidad; //velocidad de movimiento

    [SerializeField]
    float gravedad = -9.81f;

    [SerializeField]
    float alto_salto = 1f;

    [SerializeField]
    Vector3 velocidadJugador; //velocidad de caida

    bool enPiso;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        enPiso = cc.isGrounded;
        if (enPiso && velocidadJugador.y<0)
        {
            velocidadJugador.y = -2f;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        /*
         * Esto funciona solo cuando el gameobject no rota
         * En este sentido, al requerirse que el jugador rote, el codigo no es funcional, debido a que 
         * el frente (forward) del objeto cambia en tiempo de ejecucion
         * 
        horizontal = horizontal * velocidad * Time.deltaTime;
        vertical = vertical * velocidad * Time.deltaTime;
        Vector3 v_movimiento_personaje = new Vector3(horizontal, 0, vertical);
        */

        Vector3 v_movimiento_personaje = transform.right * horizontal + transform.forward * vertical;
        v_movimiento_personaje *= velocidad;
        v_movimiento_personaje *= Time.deltaTime;
        //////////////////////////////////////////////

        cc.Move(v_movimiento_personaje);

        if (Input.GetButtonDown("Jump") && enPiso) {
            //if (Input.GetKeyDown(KeyCode.Space) && enPiso)
            //if (Input.GetKeyDown(KeyCode.J) && enPiso)
            
            velocidadJugador.y += Mathf.Sqrt(alto_salto * -3.0f * gravedad);
        }
        

        velocidadJugador.y += gravedad * Time.deltaTime;
        cc.Move(velocidadJugador * Time.deltaTime);

    }
}
