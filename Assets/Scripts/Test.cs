using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private float horizontal;
    private float velocidad;
    // Ejecuta al inicio , al momento de dar play.
    void Start()
    {
        
    }

    // Se ejecuta  que vamos jugar frame x frame.
    void Update()
    {
        if (Input.GetKey("a"))
        {
            this.transform.position = new Vector2(-3, 2); // la posiscion del objeto en su vector corresponde.

        }
        if (Input.GetKey("s"))
        {
            this.transform.position = new Vector2(2, -4);

        }
       
        horizontal = Input.GetAxis("Horizontal") * velocidad;  // hacia al horizontal.
        transform.Translate(horizontal * Time.deltaTime, 0, 0); // para desplacar el objeto.


    }
}
