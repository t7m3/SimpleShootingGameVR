using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f; //弾速 [m/s]

    // Start is called before the first frame update
    void Start()
    {
        // ゲームオブジェクト前方向の速度ベクトルを計算
        var velocity = speed * transform.forward;

        //Rigidbodyコンポーネントを取得
        var rigidbody = GetComponent<Rigidbody>();

        //Rigidbodyコンポーネントを使って初速を与える
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //　トリガー領域進入時に呼び出される
    private void OnTriggerEnter(Collider other)
    {
        {
            //　衝突時に"OnHitBullet"メッセージ
            other.SendMessage("OnHitBullet");

            
            //　自身のゲームオブジェクトを破壊
            Destroy(gameObject);
        }
    }
}
