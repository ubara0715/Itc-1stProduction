using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class RE_GameCrl : MonoBehaviour
{
    //�G��͈͂̒��ň�萔(���w�肵�Ă���ȏ�ɂȂ�Ǝ~�߂�)�N����Start�֐�
    //�G�l�~�[�����̃v���n�u�ǂ��ɂ����H
    //�N���w�����c���ăR�g�H�I
    //�X�P�[�����擾����
    //�X�P�[��x�A�X�P�[��y���擾
    //�[���ă����_��������
    //�����ins�Ȃ񂽂�Ɏd����
    //�V�����X�N���v�g�ɍ��H

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

        EnemyT.text = "�c�G�� : " + enemy;
    }
}
