using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // ゲームオブジェクトをインスペクターから参照するための変数
    public GameObject Bullet;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 弾を生成する
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
