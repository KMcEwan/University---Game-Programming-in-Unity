using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour {

    public Slider myVolume;
    //public AudioSource volumeAudio;

    private void Start()
    {
        myVolume.value = 0.5f;
    }

    // Update is called once per frame
    public void VolumeController ()
    {
        //volumeAudio.volume = myVolume.value;
        //float newVol = AudioListener.volume;
        //newVol = newValue;
        // myMusic.volume = VolumeControl.value;
        AudioListener.volume = myVolume.value;
	}

}