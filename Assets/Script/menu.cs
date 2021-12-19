using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Jugar(int nivel) {
        Debug.Log("HOOOLAAAAAAAA");
        PlayerPrefs.SetInt("Nivel", nivel);
        SceneManager.LoadScene("Puzzle"); 
    }
}
