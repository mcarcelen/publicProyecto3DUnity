using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TankMovement : MonoBehaviour
{
    public float Speed = 20f;
    public float rotationSpeed = 5f;
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      //float verticalInput = Input.GetAxis("Vertical");

      Vector3 movementDirection = new Vector3(horizontalInput, 0, 0);
      movementDirection.Normalize();
    
      transform.position = transform.position + (movementDirection * Speed * Time.deltaTime);

      if(movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
