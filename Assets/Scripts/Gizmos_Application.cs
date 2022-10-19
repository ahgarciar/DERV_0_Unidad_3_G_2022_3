using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmos_Application : MonoBehaviour
{
    [SerializeField]
    Transform gizmo1;
    [SerializeField]
    Transform gizmo2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawCube(gizmo1.position, new Vector3(2,1,3));

        Gizmos.DrawSphere(gizmo2.position, 2f);

        Gizmos.DrawWireCube(transform.position, new Vector3(2, 2, 2));

        //Gizmos.
    }


}
