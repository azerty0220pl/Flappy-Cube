using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;

    public GameObject background;

    public GameObject prevStage;

    public Sprite back1;
    public Sprite back2;
    public Sprite back3;
    public Sprite back4;
    public Sprite back5;
    public Sprite back6;
    public Sprite back7;
    public Sprite back8;
    public Sprite back9;
    public Sprite back10;
    public Sprite back11;

    private void Start()
    {
        if (PlayerPrefs.GetInt("points") <= 15)
        {
            background.GetComponent<SpriteRenderer>().sprite = back1;
            PlayerPrefs.SetFloat("velocity", 2);
        }
        else if (PlayerPrefs.GetInt("points") <= 40)
        {
            background.GetComponent<SpriteRenderer>().sprite = back2;

            PlayerPrefs.SetFloat("velocity", 2);
        }
        else if (PlayerPrefs.GetInt("points") <= 70)
        {
            background.GetComponent<SpriteRenderer>().sprite = back3;
            PlayerPrefs.SetFloat("velocity", 2);
        }
        else if (PlayerPrefs.GetInt("points") <= 120)
        {
            background.GetComponent<SpriteRenderer>().sprite = back4;
            PlayerPrefs.SetFloat("velocity", 2.25f);
        }
        else if (PlayerPrefs.GetInt("points") <= 170)
        {
            background.GetComponent<SpriteRenderer>().sprite = back5;
            PlayerPrefs.SetFloat("velocity", 2.5f);
        }
        else if (PlayerPrefs.GetInt("points") <= 220)
        {
            background.GetComponent<SpriteRenderer>().sprite = back6;
            PlayerPrefs.SetFloat("velocity", 2.75f);
        }
        else if (PlayerPrefs.GetInt("points") <= 300)
        {
            background.GetComponent<SpriteRenderer>().sprite = back7;
            PlayerPrefs.SetFloat("velocity", 3);
        }
        else if (PlayerPrefs.GetInt("points") <= 410)
        {
            background.GetComponent<SpriteRenderer>().sprite = back8;
            PlayerPrefs.SetFloat("velocity", 3);
        }
        else if (PlayerPrefs.GetInt("points") <= 550)
        {
            background.GetComponent<SpriteRenderer>().sprite = back9;
            PlayerPrefs.SetFloat("velocity", 3);
        }
        else if (PlayerPrefs.GetInt("points") <= 750)
        {
            background.GetComponent<SpriteRenderer>().sprite = back10;
            PlayerPrefs.SetFloat("velocity", 3.25f);
        }
        else
        {
            background.GetComponent<SpriteRenderer>().sprite = back11;
            PlayerPrefs.SetFloat("velocity", 3.5f);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        switch (PlayerPrefs.GetInt("state"))
        {
            case 0:
                GetComponent<Rigidbody2D>().velocity = transform.up * -PlayerPrefs.GetFloat("velocity");
                obstacle1.SetActive(false);
                obstacle2.SetActive(false);
                obstacle3.SetActive(false);
                obstacle4.SetActive(false);
                obstacle5.SetActive(false);
                obstacle6.SetActive(false);
                break;
            case 1:

                if (transform.position.y > 6 && obstacle1.activeInHierarchy == obstacle2.activeInHierarchy == obstacle3.activeInHierarchy == obstacle4.activeInHierarchy == obstacle5.activeInHierarchy == obstacle6.activeInHierarchy)
                {
                    int i = Random.Range(1, 100);

                    if (i <= 20)
                        obstacle1.SetActive(true);
                    else if (i <= 40)
                        obstacle2.SetActive(true);
                    else if (i <= 60)
                        obstacle3.SetActive(true);
                    else if (i <= 75)
                        obstacle4.SetActive(true);
                    else if (i <= 90)
                        obstacle5.SetActive(true);
                    else
                        obstacle6.SetActive(true);
                }
                break;
            case 2:
                PlayerPrefs.SetInt("state", 0);
                break;

        }

        if(transform.position.y - prevStage.transform.position.y > 4.1f)
            transform.position = new Vector2(0, prevStage.transform.position.y + 4);

        if (transform.position.y < -7f)
        {
            if(PlayerPrefs.GetInt("state") == 1)
                PlayerPrefs.SetInt("points", PlayerPrefs.GetInt("points") + 1);

            transform.position = new Vector2(0, 8);

            Start();

            obstacle1.SetActive(false);
            obstacle2.SetActive(false);
            obstacle3.SetActive(false);
            obstacle4.SetActive(false);
            obstacle5.SetActive(false);
            obstacle6.SetActive(false);
        }
    }
}
