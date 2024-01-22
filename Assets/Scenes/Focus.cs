using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
    private void Awake()
    {
        Agava.WebUtility.WebApplication.InBackgroundChangeEvent += OnBackgroundChangeEvent;
    }

    private void OnBackgroundChangeEvent(bool isInBackground)
    {
        Debug.Log("Background: " + isInBackground);
        AudioListener.pause = isInBackground;
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        Debug.Log("Focus: " + hasFocus);
        AudioListener.pause = !hasFocus;
    }
}
