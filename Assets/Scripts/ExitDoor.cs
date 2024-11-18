using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public bool key0Taken = false;
    public bool key1Taken = false;
    public bool key2Taken = false;

    public GameObject portal;
    public Animator animator;
    public InfoPoint info;
    void Start(){
        portal.SetActive(false);
    }
    
    private void Update()
    {
        if (key0Taken && key1Taken && key2Taken){
            animator.SetBool("isOpen", true);
            info.TextChange("Bravo, vous avez completez le Labyrinthe, courrez vers le portail");

            portal.SetActive(true);
            
        }
    }
        
}
