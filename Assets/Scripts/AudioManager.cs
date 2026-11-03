using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;

    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicaSource; 
    [SerializeField]  private AudioSource sfxSource; 



    [Header("Audio Clips")]
    [SerializeField] private AudioClip musica;
    [SerializeField] private AudioClip click;


    [Header("Volumen") ]
    [Range(0f, 1f)]
    [SerializeField] private float volumenMusica; 
    [Range(0f, 1f)]
    [SerializeField] private float volumenSfx; 

    private bool silenciarMusica = false;
    private bool silenciarSfx = false;


    private void Awake()
        {

        if (Instance != null && Instance != this)
        {
        Destroy(gameObject);
        return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject); 
        }   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void IniciarMusica()
    {
    musicaSource.clip = musica;
    musicaSource. loop = true;
    musicaSource.Play();
    }

//Botones para encender y apagar musica 
   public void SilenciarMusica()
{
    musicaSource.mute = true;
}

public void ActivarMusica()
{
    musicaSource.mute = false;
}


//Botones para enceqnder y apagar SFX
public void SilenciarSFX()
{
    sfxSource.mute = true;
}

public void ActivarSFX()
    {
    sfxSource.mute = false;
    }


    public void CambiarVolumenMusica(float vol)
    {
    musicaSource.volume = vol;
    }

    public void PlayClick()
    {
    sfxSource.PlayOneShot(click);
    }

    public void CambiarVolumenSFX(float vol)
    {
    sfxSource.volume = vol;
    }

}
