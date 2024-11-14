using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaierAttack : MonoBehaviour
{
    [SerializeField] Transform leftSensor, rightSensor;
    [SerializeField] ParticleSystem ps;
    Ray rayonL;
    RaycastHit hitL;
    Ray rayonR;
    RaycastHit hitR;
    int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        ps.Stop(true, ParticleSystemStopBehavior.StopEmitting);

    }
    // Update is called once per frame
    void Update()
    {
        rayonL = new Ray(leftSensor.position, transform.TransformDirection(Vector3.forward));
        if(Physics.Raycast(rayonL, out hitL,Mathf.Infinity)){
            // Debug.Log("Left Sensor Objet:" + hitL.collider.name + " Distance:" + hitL.distance);
        }

        Debug.DrawRay(leftSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
        rayonR = new Ray(rightSensor.position, transform.TransformDirection(Vector3.forward));
        if (Physics.Raycast(rayonR, out hitR, Mathf.Infinity)){
            // Debug.Log("Right Sensor Objet:" + hitR.collider.name + " Distance:" + hitR.distance);
        }
        Debug.DrawRay(rightSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
        
        if(hitR.collider.name == "UggCollider" && hitL.collider.name == "UggCollider" ){
            if(Input.GetKeyDown(KeyCode.Space) || GetComponent<ClaireController>().isJumping == true){
                Debug.Log("Attack");
                ps.Play(true);
                count++;
                Debug.Log(count);
                if(count == 3){
                    Destroy(GameObject.Find("Ugg"));
                }
            }
        }
    }
}