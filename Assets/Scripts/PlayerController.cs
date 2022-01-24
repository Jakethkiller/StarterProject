using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    //Game variables

    //player variables
    public float movementSpeed;
    public Text score;
    private int scoreValue = 0;

    
    
    

    // Start is called before the first frame update
    void Start()
    {
       score.text = scoreValue.ToString();
    }

    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        //Player movement
        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(Vector2.left *Time.deltaTime * movementSpeed);
        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(Vector2.right *Time.deltaTime * movementSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag =="Fruit")
        {
            scoreValue += 3;
            score.text = scoreValue.ToString();
            Destroy(collision.collider.gameObject);
        }
        if (collision.collider.tag =="Hazard")
        {
            scoreValue += -1;
            score.text = scoreValue.ToString();
            Destroy(collision.collider.gameObject);
        }

    }

}
