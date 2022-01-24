using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    // prefabs to instantiate
   public GameObject Apple, Banana, Orange, Bomb;

    //spawn prefabs once per 2 seconds
    public float spawnRate = 2f;

    //variable to set next spawn time
    float nextSpawn = 0f;

    //variable to contain random value
    int whatToSpawn;

    //Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) 
        { //if time has come
            whatToSpawn = Random.Range (1,5); //define random value between 1 and 5
             Debug.Log (whatToSpawn); //display its value in the console

                //instantiate a prefab depending on random value
                switch (whatToSpawn)
                {
                case 1:
                Instantiate (Apple, transform.position, Quaternion.identity);
                break;

                case 2:
                Instantiate (Banana, transform.position, Quaternion.identity);
                break;

                case 3:
                Instantiate (Orange, transform.position, Quaternion.identity);
                break;

                case 4:
                Instantiate (Bomb, transform.position, Quaternion.identity);
                break;
            }

            //set nect spawn time
             nextSpawn = Time.time +spawnRate;
        }

    }
}