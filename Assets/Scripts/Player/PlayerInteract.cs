using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{ 
    private bool vaseHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Vase"))
        {
            vaseHit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && vaseHit)
        {
            SceneManager.LoadScene("FixVase");
        }
    }
}
