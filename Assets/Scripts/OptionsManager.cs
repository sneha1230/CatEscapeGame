using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsManager : MonoBehaviour
{
    public Slider volumeSlider;
    private AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    private void Update()
    {
        audioManager.SetVolume("Background", volumeSlider.value);
    }
}
