using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debuff : MonoBehaviour
{
    GameObject Player;
    public Text DebuffT;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomDebuff()
    {
        int number = (int)Random.Range(1, 4);

        switch (number)
        {
            case 1:
                Debug.Log("����");
                Player.SendMessage("Deceleration");
                DebuffT.text = "�������Ă�������";
                Invoke("TextReset", 1.0f);
                break;
            case 2:
                Debug.Log("�m�b�N�o�b�N");
                Player.SendMessage("knockBack");
                DebuffT.text = "�m�b�N�o�b�N��!!!";
                Invoke("TextReset", 1.0f);
                break;
            case 3:
                Debug.Log("���Ԍ���");
                Player.SendMessage("debuffT");
                DebuffT.text = "�������Ԃ������Ă�������Ȃ���";
                Invoke("TextReset", 1.0f);
                break;
            default:
                break;
        }
    }

    void TextReset()
    {
        DebuffT.text = "";
    }
}
