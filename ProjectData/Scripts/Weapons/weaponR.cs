using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponR : MonoBehaviour
{
    //ÉäÉlÅ[ÉÄ

    public GameObject amulet_R;
    public float shotPower;
    public float amuletsM;

    GameObject amu_R;
    public int amu_Rs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
            //Debug.Log("î≠éÀÇµÇΩÇÊ");
        }
    }

    void Shot()
    {
        if (amu_Rs < amuletsM)
        {
            amu_R = Instantiate(
                   amulet_R,
                   transform.position,
                   Quaternion.identity
                   );

            Rigidbody rb = amu_R.GetComponent<Rigidbody>();
            rb.AddForce(this.transform.up * shotPower, ForceMode.Impulse);

            CountAmu();
        }
    }

    public void CountAmu()
    {
        amu_Rs++;
        //Debug.Log("ëùÇ¶ÇΩÇ®");
    }

    public void DeathAmu()
    {
        amu_Rs--;
        //Debug.Log("å∏Ç¡ÇΩÇ®");
    }
}
