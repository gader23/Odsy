using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public GameObject camaraVisionExterna;
    public GameObject MainCamera;
    public string[] mesages;
    public MyGameManager GameManager;
    string Tag;
    public TextMeshProUGUI TextTalk;
    public Image image;
    int num = 0;
        
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camaraVisionExterna.SetActive(true);
            MainCamera.SetActive(false);
            Tag = gameObject.tag;
            if (Tag == "Robin")
            {
                if (GameManager.Robin && GameManager.count < 6)
                {
                    TextTalk.text = mesages[9];
                    num = 9;
                }
                if (GameManager.Robin && GameManager.count == 6)
                {
                    TextTalk.text = mesages[13];
                    num = 14;
                }
            }
            else
            {
                num = 0;
                TextTalk.text = mesages[0];
            }
            switch (Tag)
            {
                case "Robin":
                    if (!GameManager.Robin)
                    {
                        GameManager.Robin = true;
                        GameManager.count++;
                    }
                    break;
                case "Gaby":
                    if (!GameManager.Gaby)
                    {
                        GameManager.Gaby = true;
                        GameManager.count++;
                    }
                    break;
                case "Solete":
                    if (!GameManager.Solete)
                    {
                        GameManager.Solete = true;
                        GameManager.count++;
                    }
                    break;
                case "Eolisa":
                    if (!GameManager.Eolisa)
                    {
                        GameManager.Eolisa = true;
                        GameManager.count++;
                    }
                    break;
                case "Pollito":
                    if (!GameManager.Pollito)
                    {
                        GameManager.Pollito = true;
                        GameManager.count++;
                    }
                    break;
                case "Gaia":
                    if (!GameManager.Gaia)
                    {
                        GameManager.Gaia = true;
                        GameManager.count++;
                    }
                    break;
                        
            }
           
            TextTalk.gameObject.SetActive(true);
            image.gameObject.SetActive(true);
        }
        
    }

    void OnTriggerExit()
    {
        MainCamera.SetActive(true);
        camaraVisionExterna.SetActive(false);
        TextTalk.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
        Tag = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tag!=null)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                if(Tag== "Robin")
                {
                    if (num == 14)
                    {
                        SceneManager.LoadScene(0);
                    }
                    if (num < mesages.Length - 2)
                    {
                        if (num < 12)
                        {
                            num++;
                        }
                        
                        TextTalk.text = mesages[num];
                        
                    }
                }
                else
                {
                    if (num < mesages.Length-1)
                    {
                        num++;
                        TextTalk.text = mesages[num];
                        
                    }
                }
            }
        }
    }
}
