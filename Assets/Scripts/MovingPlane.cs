using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlane : MonoBehaviour
{
    bool Switch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Switch == true)
        {
            transform.Translate(Vector3.up * 2 * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Switch"))
        {
            Switch = true;
        }
    }
}
