using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate ()
    {
        float posH = Input.GetAxis ("Horizontal");
        float posV = Input.GetAxis ("Vertical");
        Vector3 movimiento = new Vector3 (posH, 0.0f, posV);
        rb.AddForce(movimiento * velocidad);
    }
}
