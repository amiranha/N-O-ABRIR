using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controledojogador : MonoBehaviour
{
    public float velocidade = 5;
    Vector3 direção;

    // cor 0 =base
    // cor 1 = verde
    // cor 2 = vermelho
    public Material[] Cores;

    float tempo = 0;
    public float tempoLimite = 3f;

    Renderer rederera;

    // Start is called before the first frame update
    void Start()
    {
        rederera = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        direção = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(direção * velocidade * Time.deltaTime);
        if (tempo > tempoLimite)
        {
            rederera.material = Cores[1];
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Vermelho>() != null)
        {
            Morre();
        }

        else if (other.GetComponent<Verde>() != null)
        {
            if (rederera.material == Cores[1])
            {
                Morre();
            }
            else
            {
                rederera.material = Cores[1];
                tempo = 0;
            }
            
        }
           
    }



    private void Morre()
    {
        Destroy(this.gameObject);
    }
}