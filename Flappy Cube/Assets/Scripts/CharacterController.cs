using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public GameObject MainMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("state", 2);
    }

    private void Update()
    {
        switch (PlayerPrefs.GetInt("state"))
        {
            case 0:
                transform.position = new Vector2(0, -3);
                break;

            case 1:
                if (transform.position.x < 0)
                    GetComponent<Rigidbody2D>().AddForce(-transform.right * 3f);
                else
                    GetComponent<Rigidbody2D>().AddForce(transform.right * 3f);

                if (/*Input.GetTouch(0).phase == TouchPhase.Began ||*/ Input.GetMouseButtonDown(0))
                {
                    GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                    if (transform.position.x < 0)
                        GetComponent<Rigidbody2D>().AddForce(transform.right * 2.25f, ForceMode2D.Impulse);
                    else
                        GetComponent<Rigidbody2D>().AddForce(-transform.right * 2.25f, ForceMode2D.Impulse);
                }
                break;

            case 2:
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                MainMenu.SetActive(true);
                break;
        }
    }
}
