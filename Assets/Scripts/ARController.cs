using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class ARController : MonoBehaviour
{
 [SerializeField] private Button boton;
 [SerializeField] private GameObject model;

[SerializeField] private TextMeshProUGUI textoBoton;

 private bool modelState = false;
  public void ButtonHandle(bool state)
    {
        boton.interactable = state;

        if (!state)
        {
            model.SetActive(false);
        }
        else
        {
            model.SetActive(true);
        }
    }

    public void ModelHandle()
    {
        if (!modelState)
        {
            model.SetActive(true);
            modelState = true;
            textoBoton.text = "Ocultar Modelo";
    

        }
        else
        {
            model.SetActive(false);
            modelState = false;
            textoBoton.text = "Mostrar Modelo";
            //Act mostrar y ocultar texto boton 
        }
    }

}
