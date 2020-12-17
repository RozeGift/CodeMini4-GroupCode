using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesScript : MonoBehaviour
{
    public Renderer PlateRBr;
    public Material[] plateMat;
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
        if (collision.gameObject.CompareTag("Player"))
        {
            PlateRBr.material.color = plateMat[0].color;
        }
    }
}
