using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveComponent : MonoBehaviour
{
    public int speed = 10;
    bool colision = false;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (!colision)
            transform.Translate((Vector3.forward * Input.GetAxis("Vertical")) * speed * Time.deltaTime);



    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("enviroments"))
        {
            colision = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("enviroments"))
        {
            colision = false;
        }
    }
}
