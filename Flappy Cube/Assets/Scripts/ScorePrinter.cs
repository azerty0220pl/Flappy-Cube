using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePrinter : MonoBehaviour
{
    public GameObject scoreObject;
    Text scoreText;

    public GameObject path1;

    // Update is called once per frame
    void Update()
    {
        scoreText = scoreObject.GetComponent<Text>();
        scoreText.text = "" + PlayerPrefs.GetInt("points");

        path1.GetComponent<Image>().fillAmount = ((float) PlayerPrefs.GetInt("points")) / 750;
    }
}
