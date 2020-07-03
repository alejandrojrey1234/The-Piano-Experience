using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TocarMusica : MonoBehaviour
{

    public Sound nota; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollitionEnter(Collision collision)
    {
        if (collision.collider.tag == "PhysicsPusher")
        {
            FindObjectOfType<AudioManager>().Play("c3");       
        }
    }
}
