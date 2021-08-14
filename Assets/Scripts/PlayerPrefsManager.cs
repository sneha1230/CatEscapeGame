using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master_volume";
    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Volume Out of Range ");
        }

    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
}
