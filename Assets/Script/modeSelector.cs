using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class modeSelector : MonoBehaviour
{
    public void sounds() {
        SceneManager.LoadScene("Sounds"); 
    }

    public void puzzles() {
        SceneManager.LoadScene("PuzzleSelector"); 
    }
}
