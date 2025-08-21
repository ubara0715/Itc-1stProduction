using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //GameCrtÇ…édçûÇﬁ

    public float TimeLimit;
    public Text time;

    public bool Goal = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //TimeLimit -= Time.deltaTime;

        if (Goal)
        {
            return;
        }

        TimeLimit -= Time.deltaTime;

        time.text = ((int)(TimeLimit / 60)).ToString("00") + ":" + ((int)TimeLimit % 60).ToString("00");

        if(TimeLimit <= 0)
        {
            time.text = "Å_(^o^)Å^";

            Invoke("Clear", 1.5f);

            return;
        }

        
    }

    void Clear()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
