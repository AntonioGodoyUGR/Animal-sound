using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{

    [SerializeField] private AudioClip[] audios;

    private AudioSource controlAudio;

    void Start() {
        Debug.Log("ENTRO EN START");
        controlAudio = GetComponent<AudioSource>();
        Debug.Log(controlAudio);
    }

    public void seleccionAudio(int indice, float volume) {
        Debug.Log("indice");
        Debug.Log(indice);
        Debug.Log(audios[indice]);
        Debug.Log(volume);
        Debug.Log(controlAudio);

        controlAudio.PlayOneShot(audios[indice], volume);
    }
}
