﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] float spawnInterval = 4.2f; //　敵出現間隔

    EnemySpawner[] spawners; // EnemySpawnerのリスト
    float timer = 0f;        // 出現時間判定用のタイマー変数

    int index = 0; //　EnemySpawner を選択する変数

    // Start is called before the first frame update
    void Start()
    {
        //　子オブジェクトに存在する EnemySpawner のリストを取得
        spawners = GetComponentsInChildren<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        //　タイマー更新
        timer += Time.deltaTime;
        Debug.Log(timer);

        //　出現間隔の判定
        if (spawnInterval < timer)
        {
            //　ランダムに EnemySpawner を選択して敵を出現させる
            //var index = Random.Range(0, spawners.Length);

            //　順番にに EnemySpawner を選択して敵を出現させる
            if(index++ == spawners.Length) 
                index = 0;

            spawners[index].Spawn();

            //　タイマーリセット
            timer = 0f;
        }
    }
}
