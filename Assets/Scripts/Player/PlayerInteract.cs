using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{ 
    private bool vaseHit;
    public int vaseCount = 0;

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
        if(vaseHit && Input.GetKeyDown(KeyCode.E))
        {
            vaseCount++;
            SceneManager.LoadScene("FixVase");
            vaseHit = false;
        }
        
        if(vaseCount == 3)
        {
            SceneManager.LoadScene("Letter");
        }

    }
}
