using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Objetos;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }
    IEnumerator SpawnObject()
    {
        while(true)
        {
            int spawnPointX = Random.Range(-11,7);
            int spawnPointY = Random.Range(10,20);
            int spawnPointZ = Random.Range(-50,110);
            int numObj = Random.Range(0, Objetos.Length);

            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
            GameObject objeto = Instantiate(Objetos[numObj], spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(3f);
            //Destroy(objeto, 6f);
        }

    }
}
