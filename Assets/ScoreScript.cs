using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private int playerScore1 = 0;
    [SerializeField]
    private int playerScore2 = 0;
    private bool EndGame = false;
    [SerializeField]
    private int WinningScore = 10; 


    public Text score;
  //  public GameObject ball;  

    // Start is called before the first frame update
    void Start()
    {
    //    ball = GameObject.Find("Ball 1");
    }

    private void FixedUpdate()
    {

        if (EndGame) 
            if(Input.GetButton("Jump"))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (playerScore1 >= WinningScore)
            {
                score.text = (" Green Wins! Press Space to Play Again! "); // NEW CODE
             

                EndGame = true;

            }
            else if (playerScore2 >= WinningScore)
            {
                score.text = (" Red Wins! Press Space to Play Again!");
                

                EndGame = true;
            }

        


    }

    public void PlayerOneScore()
    {
        if (!EndGame)
        {
            playerScore2++;
            score.text = playerScore1.ToString() + " - " + playerScore2.ToString(); // NEW CODE

            // in unity your print funcion is Debug.Log("");
            Debug.Log(playerScore1 + " , " + playerScore2);
        }
    }

    public void PlayerTwoScore()
    {
        if (!EndGame)
        {
            playerScore1++;
            score.text = playerScore1.ToString() + " - " + playerScore2.ToString(); // NEW CODE

            // in unity your print funcion is Debug.Log("");
            Debug.Log(playerScore1 + " , " + playerScore2); // 
        }
    }

}
