using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portail : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Inside portal");
        }
        }
}
