using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    //���ׂẴV�[���ɃI�u�W�F�N�g����ăA�^�b�`����

    // Start is called before the first frame update
    void Start()
    {
        //�J�[�\���̌����ڂ��I�t
        Cursor.visible = false;
        //�J�[�\���𒆐S�ɌŒ�
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
