using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Inst : MonoBehaviour
{
    //float scaleX;
    //float scaleY;

    //public int enemy_max;

    public GameObject[] enemys;
    GameObject enemy_c;
    GameObject Enemys;

    // Start is called before the first frame update
    void Start()
    {
        /*
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;

        float scaleX_Random = Random.Range(-scaleX, scaleX);
        float scaleY_Random = Random.Range(-scaleY, scaleY);

        Vector3 EnemyRange = new Vector3(scaleX_Random, scaleY_Random, 0.1f);

        for(int i = 0; i < enemy_max; i++)
        {
            Instantiate(
            SampleEnemy(),
            transform.position,
            Quaternion.identity
            );
        } 
        */

        Enemys = GameObject.Find("Enemys");

        enemy_c = 
        Instantiate(
            SampleEnemy(),
            transform.position,
            Quaternion.identity
            );

        enemy_c.AddComponent<Rigidbody>();

        enemy_c.transform.parent = Enemys.transform;
    }

    GameObject SampleEnemy()
    {
        int index = Random.Range(0, enemys.Length);
        return enemys[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
