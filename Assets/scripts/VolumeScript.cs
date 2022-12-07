using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{

    public Slider slider;
    public float slideValue;
    public Image imagenMute;
    
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("audioVolume", 0.5f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }

    public void ChangeSlider(float valor)
    {
        slideValue = valor;
        PlayerPrefs.SetFloat("audioVolume", slideValue);
        AudioListener.volume = slider.value;
    }

     public void RevisarSiEstoyMute()
    {

        if(slideValue == 0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }








    }
}
