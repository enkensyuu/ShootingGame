using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // �Q�[���I�u�W�F�N�g���C���X�y�N�^�[����Q�Ƃ��邽�߂̕ϐ�
    public GameObject Bullet;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �e�𐶐�����
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
