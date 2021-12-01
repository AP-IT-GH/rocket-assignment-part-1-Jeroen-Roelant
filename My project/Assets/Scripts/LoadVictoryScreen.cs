using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVictoryScreen : MonoBehaviour
{
    public GameObject victoryCanvas;
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("t");
        victoryCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }
}
