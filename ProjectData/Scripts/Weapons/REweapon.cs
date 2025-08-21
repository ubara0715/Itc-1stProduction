using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REweapon : MonoBehaviour
{
    //weapomController‚É‰ü–¼‚·‚é
    //ƒŠƒl[ƒ€

    public GameObject[] weapons;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject gameObj in weapons)
        {
            gameObj.SetActive(false);
        }

        weapons[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")) changeR();

        /*
        if (Input.GetKeyDown("e")) changeR();

        if (Input.GetKeyDown("q")) changeL();
        */
    }

    void changeR()
    {
        weapons[index].SetActive(false);
        index++;

        if(index > 2)
        {
            index = 0;
        }

        weapons[index].SetActive(true);
    }

    void changeL()
    {
        weapons[index].SetActive(false);
        index--;

        if (index < 0)
        {
            index = 2;
        }

        weapons[index].SetActive(true);
    }
}
