using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerEvents : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
        {
         //   Debug.Log("call");
        }
        Debug.Log(other.gameObject.tag);
       // other.gameObject.SetActive(false);
    }
/*
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("Object In");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("Object Exit");
        }
    }*/
}
