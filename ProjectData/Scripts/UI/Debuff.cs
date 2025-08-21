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
                Debug.Log("減速");
                Player.SendMessage("Deceleration");
                DebuffT.text = "減速してもうたな";
                Invoke("TextReset", 1.0f);
                break;
            case 2:
                Debug.Log("ノックバック");
                Player.SendMessage("knockBack");
                DebuffT.text = "ノックバックだ!!!";
                Invoke("TextReset", 1.0f);
                break;
            case 3:
                Debug.Log("時間減少");
                Player.SendMessage("debuffT");
                DebuffT.text = "制限時間が減ってもうたやないか";
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
