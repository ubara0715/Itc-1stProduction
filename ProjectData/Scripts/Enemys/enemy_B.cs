using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_B : MonoBehaviour
{
    GameObject Player;
    GameObject DebuffObj;
    Debuff Debuff;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        DebuffObj = GameObject.Find("Debuff");
        Debuff = DebuffObj.GetComponent<Debuff>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "amulet_B")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "amulet_R")
        {
            Debuff.RandomDebuff();
        }

        if (collision.gameObject.tag == "amulet_G")
        {
            Debuff.RandomDebuff();
        }
    }
}

