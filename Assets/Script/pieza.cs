using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pieza : MonoBehaviour
{
    private Vector3 PosicionCorrecta;
    public bool Encajada;
    public bool Seleccionada;

    void Start()
    {
        PosicionCorrecta = transform.position;
        transform.position = new Vector3(Random.Range(-2f, 2f), Random.Range(-1f,-4.2f), 0.0f);
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);

    }

    void Update()
    {
        if (Vector3.Distance(transform.position, PosicionCorrecta) < 0.5f)
        {
            if (!Seleccionada)
            {
                if (Encajada == false)
                {
                    transform.position = PosicionCorrecta;
                    Encajada = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<juego>().PiezasEncajadas++;
                }
            }
        }
    }
}
