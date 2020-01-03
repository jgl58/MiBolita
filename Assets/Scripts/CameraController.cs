using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 desplazamiento;
    // Use this for initialization
    void Start () {
        desplazamiento = transform.position - player.transform.position;
    }
    // LateUpdate is called once per frame at the end
    void LateUpdate () {
        transform.position = player.transform.position + desplazamiento;
    }
}
