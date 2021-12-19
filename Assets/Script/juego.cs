using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class juego : MonoBehaviour
{
    public Sprite[] Niveles;

    public GameObject MenuGanar;
    public GameObject PiezaSeleccionada;
    int capa = 1;    
    public int PiezasEncajadas = 0;

void Start()
    {
        for (int i = 0;i <36; i++)
        {
            //PlayerPrefs.GetInt("Nivel")
            GameObject.Find("PIeza (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Niveles[2];

        }
    }
void Update()
    {
    // Update is called once per frame
    if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector3.zero);
            Debug.Log(hit.transform);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<pieza>().Encajada)
                {
                    PiezaSeleccionada = hit.transform.gameObject;
                    PiezaSeleccionada.GetComponent<pieza>().Seleccionada = true;
                    PiezaSeleccionada.GetComponent<SortingGroup>().sortingOrder = capa;
                    capa++;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (PiezaSeleccionada != null)
            {
                Debug.Log("Pieza seleccionada != null");
                PiezaSeleccionada.GetComponent<pieza>().Seleccionada = false;
                PiezaSeleccionada = null;
            }
        }
        if (PiezaSeleccionada != null)
        {
            Vector3 raton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PiezaSeleccionada.transform.position = new Vector3(raton.x,raton.y,0);
        }             
        if (PiezasEncajadas == 36)
        {
            MenuGanar.SetActive(true);
        }
    }
}
