using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed = 5f; //弾速 [m/s]

    // Start is called before the first frame update
    void Start()
    {
        // ゲームオブジェクト前方向の速度ベクトルを計算
        var velocity = speed * transform.right;

        //Rigidbodyコンポーネントを取得
        var rigidbody = GetComponent<Rigidbody>();

        //Rigidbodyコンポーネントを使って初速を与える
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //　OnHitBulletメッセージから呼び出されることを想定
    void OnHitBullet()
    {
        //　自身のゲームオブジェクトを破棄
        Destroy(gameObject);
    }

}
