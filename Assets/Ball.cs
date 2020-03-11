using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour
{
    public float speed = 47;
    private AudioSource  snd; //Audio
    private Rigidbody2D rb;

    // creates an option for the score script in the inspector. 
    public ScoreScript score; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        rb.velocity = Vector2.right * speed;
        snd = GetComponent<AudioSource>(); // Audio
    }

    // Update is called once per frame NEW CODE
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // to do - refactor
        if(col.gameObject.name == "leftPaddle")
        {
            float y = calculatePosition(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            rb.velocity = direction * speed;
            snd.Play(); // Audio
        }

        if(col.gameObject.name == "rightPaddle")
        {
            float y = calculatePosition(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, 0).normalized;
            rb.velocity = direction * speed;
            snd.Play(); // Audio
        }

        if(col.gameObject.name == "LeftWall")
        {
            Debug.Log("have hit left wall");
            //rb.velocity = Vector2.zero;
            score.PlayerOneScore();
            snd.Play();
        }

        if(col.gameObject.name == "RightWall")
        {
            Debug.Log("Have hit right wall");
            //rb.velocity = Vector2.zero;
            score.PlayerTwoScore();
            snd.Play();
        }
    }



    float calculatePosition(Vector2 ballPosition, Vector2 PaddlePosition, float paddleHeight)
    {
        float value = (ballPosition.y - PaddlePosition.y) / paddleHeight;
        return (value); 
    }


}
