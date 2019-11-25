using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed = 5f; //弾速 [m/s]

    [SerializeField] int point = 10;  // 倒したときに加算する得点
    ScoreText scoreText;  // ScoreTextクラス（Script）の参照値を格納するオブジェクト変数

    // Start is called before the first frame update
    void Start()
    {
        // ゲームオブジェクト前方向の速度ベクトルを計算
        var velocity = speed * transform.right;

        //Rigidbodyコンポーネントを取得
        var rigidbody = GetComponent<Rigidbody>();

        //Rigidbodyコンポーネントを使って初速を与える
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);

        // ゲームオブジェクトを検索
        var gameObj = GameObject.FindWithTag("ScoreText");

        // gameObjに含まれるScoreTextコンポーネントの参照値を取得
        scoreText = gameObj.GetComponent<ScoreText>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //　OnHitBulletメッセージから呼び出されることを想定
    void OnHitBullet()
    {

        // スコアを加算
        scoreText.AddScore(point);

        //Debug.Log("Enemyスクリプトに来た");

        //　自身のゲームオブジェクトを破棄
        Destroy(gameObject);

    }

}
