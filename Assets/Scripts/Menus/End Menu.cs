﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public Button continueButton;

    public string Clubhouse;

    public void GotoGame()
    {
        SceneManager.LoadScene("Menu");
    }
}

