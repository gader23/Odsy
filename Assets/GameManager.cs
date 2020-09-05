using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
   public bool Robin;
   public bool Gaby;
   public bool Solete;
    public bool Pollito;
  public   bool Eolisa;
  public  bool Gaia;
   public int count;
    public TextMeshProUGUI TextCount;

    // Start is called before the first frame update
    void Start()
    {
        Robin = false;
        Gaby = false;
        Solete = false;
        Pollito = false;
        Eolisa = false;
        Gaia = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextCount.text = "ERbots: " + count + "/6";
    }
}
