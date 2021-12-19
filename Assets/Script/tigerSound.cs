using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tigerSound : MonoBehaviour
{
    private playSound playSound;

    private void Awake() {
        playSound = FindObjectOfType<playSound>();
    }

    public void soinidoTigre(){
        int indice = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        playSound.seleccionAudio(indice, 0.5F);
    }
}
