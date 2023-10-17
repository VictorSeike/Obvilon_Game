using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigManager : MonoBehaviour
{

    public float volume = 1.0f;
    
    void Start()
    {
        volume = PlayerPrefs.GetFloat("Volume", 1.0f);
    }


    void Update()
    {
        
    }

    public void SaveConfig()
    {
        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save();
    }
}
