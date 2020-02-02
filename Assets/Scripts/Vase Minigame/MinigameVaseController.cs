using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameVaseController : MonoBehaviour
{

    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Puzzle1.locked && Puzzle2.locked && Puzzle3.locked && Puzzle4.locked && Puzzle5.locked && Puzzle6.locked && Puzzle7.locked)
        {
            SceneManager.LoadScene("Mansion");
        }
    }
}
