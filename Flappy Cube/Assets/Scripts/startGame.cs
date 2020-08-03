using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.SetInt("state", 1);
        TinySauce.OnGameStarted();
    }
}
