using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class CubeScaler : MonoBehaviour //, IMixedRealitySpeechHandler
{
    //Achtung: die verwendeten Keywords müssen unter MixedRealityToolkit/Input/Speech eingetragen sein!

    //Erkennung direkt gelöst, hierfür muss von IMixedRealitySpeechHandler geerbt werden
    /*
    void IMixedRealitySpeechHandler.OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        if (eventData.Command.Keyword == "Smaller")
        {
            transform.localScale *= 0.5f;
            Debug.Log("Smaller");
        }
        else if (eventData.Command.Keyword == "Bigger")
        {
            transform.localScale *= 2.0f;
            Debug.Log("bigger");
        }
    }
    */

    //Erkennung von Keywords und Aufruf der Funktionen findet in SpeechInputHandler Script auf SpeechControler statt
    public void smaller()
    {
        transform.localScale *= 0.5f;
        Debug.Log("Smaller");
    }

    public void bigger()
    {
        transform.localScale *= 2.0f;
        Debug.Log("Bigger");
    }

}