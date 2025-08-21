using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amulet_R : MonoBehaviour
{
    //メモ
    //エフェクトの管理をここにかく
    //お札にタグ付ける
    //お札(アカ)につける
    //リネーム

    //public float shotPower;
    public float deathT;
    GameObject weapon;
    weaponR weaponR;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.up * shotPower, ForceMode.Impulse);
        weapon = GameObject.FindWithTag("weapon");
        weaponR = weapon.GetComponent<weaponR>();

        Destroy(gameObject, deathT);
        Invoke("SendMes", deathT - 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SendMes()
    {
        //Debug.Log("送ったよ");
        weapon.SendMessage("DeathAmu");
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if(collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            weaponR.DeathAmu();
        }

        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            weaponR.DeathAmu();
        }
    }
}
