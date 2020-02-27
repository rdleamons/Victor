using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameVaseController : MonoBehaviour
{

    [SerializeField]
    PlayerInteract testCount;

    // Start is called before the first frame update
    void Start()
    {
        Puzzle1.locked = false;
        Puzzle2.locked = false;
        Puzzle3.locked = false;
        Puzzle4.locked = false;
        Puzzle5.locked = false;
        Puzzle6.locked = false;
        Puzzle7.locked = false;
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
