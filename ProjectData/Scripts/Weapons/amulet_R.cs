using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amulet_R : MonoBehaviour
{
    //����
    //�G�t�F�N�g�̊Ǘ��������ɂ���
    //���D�Ƀ^�O�t����
    //���D(�A�J)�ɂ���
    //���l�[��

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
        //Debug.Log("��������");
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
