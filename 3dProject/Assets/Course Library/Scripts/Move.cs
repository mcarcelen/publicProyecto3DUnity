using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0,0,-20) * Time.deltaTime;
    }
    
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
