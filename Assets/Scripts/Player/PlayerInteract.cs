using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{ 
    private bool vaseHit;
    private bool webHit;
    public int vaseCount;
    public int webCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vase"))
        {
            vaseCount++;
            vaseHit = true;
            webHit = false;
            
        }
        else if(collision.gameObject.CompareTag("Web"))
        {
            webCount++;
            webHit = true;
            vaseHit = false;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(vaseHit == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("FixVase");
            vaseHit = false;
        }else if(webHit == true && Input.GetKeyDown(KeyCode.E))
        {   
            SceneManager.LoadScene("CleanCobwebs");
            webHit = false;
        }

        /*
        if(vaseCount >= 3 && webCount >= 3)
        {
            SceneManager.LoadScene("Letter");
            vaseCount = 0;
            webCount = 0;
        }
        */

    }
}
