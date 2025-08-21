using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public GameObject Player;
    //GameObject debuffObj;
    //debuff debuff;

    //string Debuff;
    GameObject Player;

    GameObject DebuffObj;
    Debuff Debuff;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");

        DebuffObj = GameObject.Find("Debuff");
        Debuff = DebuffObj.GetComponent<Debuff>();
        //debuffObj = GameObject.Find("debuff");
        //debuff = GetComponent<debuff>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debuff = debuff.yourDebuff;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "amulet_R")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "amulet_B")
        {
            Debuff.RandomDebuff();
        }

        if (collision.gameObject.tag == "amulet_G")
        {
            Debuff.RandomDebuff();
        }
    }
}
