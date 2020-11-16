using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogar : MonoBehaviour
{

    public float velocidade = 2;
    Vector3 direção;


    public material[] Cores;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direção = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(direção * velcoidade * Time.deltaTime);
    }
}

private void OntriggerEnter(Colider other)
{
   
        if (other.GetComponent<verde>()!= null)
    {
        Morre();
    }
       

        private void Morre()
    {

        Destroy(this.gameObject);

    }



}
