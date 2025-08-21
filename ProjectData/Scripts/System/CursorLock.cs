using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    //すべてのシーンにオブジェクト作ってアタッチする

    // Start is called before the first frame update
    void Start()
    {
        //カーソルの見た目をオフ
        Cursor.visible = false;
        //カーソルを中心に固定
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
