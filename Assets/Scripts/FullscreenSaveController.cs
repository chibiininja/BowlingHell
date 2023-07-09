using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullscreenSaveController : MonoBehaviour
{
    [SerializeField] private Toggle toggle = null;

    private void Start()
    {
        LoadValues();
    }
    public void SaveFullscreen() {
        int fullscreenValue = toggle.isOn ? 1 : 0;
        PlayerPrefs.SetInt("FullscreenValue", fullscreenValue);
        LoadValues();
    }
    void LoadValues() 
    {
        int fullscreenValue = PlayerPrefs.GetInt("FullscreenValue");
        toggle.isOn = fullscreenValue == 1 ? true : false;
        Screen.fullScreen = fullscreenValue == 1? true : false;
    }
}
