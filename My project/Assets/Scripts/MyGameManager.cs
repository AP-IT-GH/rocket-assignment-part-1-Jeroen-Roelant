using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameObject victoryCanvas;

    public int coins = 0;
    private Health healthPlayer;

    public enum GameStates { Playing, Gameover}

    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        healthPlayer = player.GetComponent<Health>();
        victoryCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                
                mainCanvas.SetActive(true);
                gameOverCanvas.SetActive(false);
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.Gameover;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }
                else 
                {

                }
                break;
            case GameStates.Gameover:
                break;
            default:
                break;
        }
    }

    public void AddCoin()
    {
        coins++;
    }
}
