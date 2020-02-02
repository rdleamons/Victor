﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    [SerializeField] private string newLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.E) && collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }
}
