using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefabProyectil;
    public float fuerza;
    public Transform posicion;
    void Update(){
        if (Input.GetButtonDown("Fire1")){
            Disparar();
        }
    }
    void Disparar(){
        //1. Crear el objeto
        GameObject go = Instantiate(
            prefabProyectil, posicion.position, posicion.rotation);
        //2. Aplicación de la fuerza
        go.GetComponent<Rigidbody>().AddForce(
            posicion.forward*fuerza
        );

    }
}
