using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorTorreta : MonoBehaviour
{
    private float h;
    [SerializeField]
    private float velocidadGiroHorizontal;

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        transform.Rotate(0,h*Time.deltaTime*velocidadGiroHorizontal,0);
    }
}
