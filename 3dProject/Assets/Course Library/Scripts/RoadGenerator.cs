using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class RoadGenerator : MonoBehaviour
{
    public GameObject roadSection;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection, new Vector3(-2.5f, 1.8f, 183), new Quaternion(0f, 0.707f, 0f, 0.707f));
        }
    }
}