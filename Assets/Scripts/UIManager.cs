using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public Slider sliderMusica; 
    public Slider sliderSFX;
    public Image iconoMusica;
    public Image iconoSFX;

    public TextMeshProUGUI porcentajeMusica;
    public TextMeshProUGUI porcentajeSFX;

    [SerializeField] private Sprite sonido;
    [SerializeField] private Sprite silencio;

    private float volumenAnterior = 1f;

public void ActualizarUIMuisca()
    {
        AudioManager.Instance.CambiarVolumenMusica(sliderMusica.value);
        float value = sliderMusica.value * 100;
        porcentajeMusica.text = value.ToString("F0") + "%";
        ActualizarIcono(iconoMusica, sliderMusica.value);
    }

public void ActualizarUISFX()
    {
        AudioManager.Instance.CambiarVolumenSFX(sliderSFX.value);
        float value = sliderSFX.value * 100;
        porcentajeSFX.text = value.ToString("F0") + "%";
        ActualizarIcono(iconoSFX, sliderSFX.value);
    }


    public void ActualizarIcono(Image icono, float sliderValue)
    {
        if (sliderValue == 0)
        {
            icono.sprite = silencio;
        }
        else
        {
            icono.sprite = sonido;
        }
    }
public void BotonSilenciarMusica()
{
    if (sliderMusica.value > 0)
    {
        volumenAnterior = sliderMusica.value;
        sliderMusica.value = 0;

        AudioManager.Instance.SilenciarMusica();
    }
    else
    {
        sliderMusica.value = volumenAnterior;

        AudioManager.Instance.ActivarMusica();
    }
}

public void BotonSilenciarSFX()
{
    if (sliderSFX.value > 0)
    {
        volumenAnterior = sliderSFX.value;
        sliderSFX.value = 0;


        AudioManager.Instance.SilenciarSFX();
    }
    else
    {
        sliderSFX.value = volumenAnterior;

        AudioManager.Instance.ActivarSFX();
    }
}

}
