using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killwall : MonoBehaviour
{
   //runs code when an object collides with the object that this script is attached to

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //destroys the objects that collide with the object this script is attached to
        Destroy (collision.gameObject);

    }

}
