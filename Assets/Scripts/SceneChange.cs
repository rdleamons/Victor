using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField]
    private string newLevel;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") /*&& Input.GetKey(KeyCode.E)*/)
        {
            SceneManager.LoadScene(newLevel);
        }
    }
}
