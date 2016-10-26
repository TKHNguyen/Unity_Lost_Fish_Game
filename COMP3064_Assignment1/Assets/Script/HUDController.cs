using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    [SerializeField]
    Text points = null;
    [SerializeField]
    Text health = null;
    [SerializeField]
    GameObject player = null;
    [SerializeField]
    Text gameover = null;
    [SerializeField]
    Text highscore = null;
    [SerializeField]
    Text currentscore = null;
    [SerializeField]
    Button restart = null;
    [SerializeField]
    Button start = null;
    [SerializeField]
    GameObject mermaid = null;
    [SerializeField]
    GameObject shark = null;
    [SerializeField]
    GameObject submarine = null;
    [SerializeField]
    GameObject coinSpawn = null;
    [SerializeField]
    GameObject bulletSpawn = null;
    [SerializeField]
    GameObject coin = null;
    [SerializeField]
    GameObject bullet = null;


    void Start()
    {
        //initialize point, health and player
        points.text = "Points : 0";
        health.text = "Health: 100";
        Player.Instance.hub = this;

        //set those flowing gameObjects to be invisible
        player.SetActive(false);
        gameover.gameObject.SetActive(false);
        highscore.gameObject.SetActive(false);
        currentscore.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        mermaid.gameObject.SetActive(false);
        shark.gameObject.SetActive(false);
        submarine.gameObject.SetActive(false);
    }
    void Update()
    {
        //The shark will be active when user's score is greater than 50
        if (Player.Instance.Points > 50)
        {
            shark.gameObject.SetActive(true);
        }
        else shark.gameObject.SetActive(false);

        //The mermaid will be active when user's health is less than 50
        if (Player.Instance.Health < 50)
        {
            mermaid.gameObject.SetActive(true);
            coinSpawn.gameObject.SetActive(true);
            coin.gameObject.SetActive(true);
        }
        else
        {
            mermaid.gameObject.SetActive(false);
            coinSpawn.gameObject.SetActive(false);
            coin.gameObject.SetActive(false);
        }

        //The submarine will be active when user's score greater than 100
        if (Player.Instance.Points > 100)
        {
            submarine.gameObject.SetActive(true);
            bulletSpawn.gameObject.SetActive(true);
            bullet.gameObject.SetActive(true);
        }
        else
        {
            submarine.gameObject.SetActive(false);
            bulletSpawn.gameObject.SetActive(false);
            bullet.gameObject.SetActive(false);
        }
    }

    //update points
    public void UpdatePoints()
    {
        points.text = "Points: " + Player.Instance.Points;
    }

    //update health
    public void UpdateHealth()
    {
        health.text = "Health: " + Player.Instance.Health;
    }
    public void GameOver()
    {
        //set those flowing gameObjects to be invisible
        points.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        player.SetActive(false);

        //set those following gameObjects to be visible  and active
        gameover.gameObject.SetActive(true);
        //set high score
        highscore.text = "High Score " + Player.Instance.HighScore;
        currentscore.text = "Current Score " + Player.Instance.Points;

        highscore.gameObject.SetActive(true);
        currentscore.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);

    }
    public void ResetGame()
    {
        
        //set those following gameObjects to be visible  and active
        points.gameObject.SetActive(true);
        health.gameObject.SetActive(true);
        player.SetActive(true);

        //set those flowing gameObjects to be invisible
        submarine.gameObject.SetActive(false);
        mermaid.gameObject.SetActive(false);
        shark.gameObject.SetActive(false);
        gameover.gameObject.SetActive(false);
        highscore.gameObject.SetActive(false);
        currentscore.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        coinSpawn.gameObject.SetActive(false);
        bulletSpawn.gameObject.SetActive(false);
        Player.Instance.Health = 100;
        Player.Instance.Points = 0;

    }
    public void StartButton()
    {
        //set those following gameObjects to visible  and active
        points.gameObject.SetActive(true);
        health.gameObject.SetActive(true);
        player.SetActive(true);

        //set button start to be invisible
        start.gameObject.SetActive(false);

        //initialize health and point
        Player.Instance.Health = 100;
        Player.Instance.Points = 0;
    }

}
