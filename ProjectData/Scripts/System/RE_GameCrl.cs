using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class RE_GameCrl : MonoBehaviour
{
    //敵を範囲の中で一定数(数指定してそれ以上になると止める)湧かすStart関数
    //エネミーたちのプレハブどこにおく？
    //湧き層を作る…ってコト？！
    //スケールを取得する
    //スケールx、スケールyを取得
    //ーつけてランダム化する
    //それをinsなんたらに仕込む
    //新しいスクリプトに作る？

    public GameObject Gates;
    GameObject[] enemys;
    //GameObject Sporns;
    //MeshRenderer meshRenderer;
    public Text EnemyT;
    //public Text DebuffT;

    //public GameObject PlayerObj;
    //Player Player;

    int enemy;

    // Start is called before the first frame update
    void Start()
    {
        //Gates = GameObject.Find("gates");
        /*
        Sporns = GameObject.FindWithTag("Sporn");
        meshRenderer = Sporns.GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        */

        //Player = PlayerObj.GetComponent<Player>();

        enemys = GameObject.FindGameObjectsWithTag("enemy");
        enemy = enemys.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //Sporns = GameObject.FindWithTag("Sporn");
        //ren = Sporns.GetComponent<MeshRenderer>();
        //ren.enabled = false;

        //enemys = GameObject.FindGameObjectsWithTag("enemy");
        //enemy = enemys.Length;
        //Debug.Log(enemy);

        if(enemy <= 0)
        {
            Destroy(Gates.gameObject);
        }

        EnemyT.text = "残敵数 : " + enemy;
    }
}
