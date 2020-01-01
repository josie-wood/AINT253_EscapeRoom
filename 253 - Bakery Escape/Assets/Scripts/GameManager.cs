﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void loseScreen()
    {
        SceneManager.LoadScene("Lose");
    }

    public void winScreen()
    {
        SceneManager.LoadScene("Win");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
