using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    Text uitext;  // UIText　コンポーネント　の参照値を格納するためのオブジェクト変数
    public int Points { get; private set; }  //現在のスコアポイント　・・・　get と set は、何か？

    // Start is called before the first frame update
    void Start()
    {
        uitext = GetComponent<Text>();  // Textオブジェクト（Textコンポーネント）の参照値を格納している。
    }

    public void AddScore(int addPoint)
    {
        //Debug.Log("ScoreTextスクリプトのAddScore関数に来た");

        // 現在のポイントに加算
        Points += addPoint;

        // 得点の更新
        uitext.text = string.Format("得点：{0:D3}点", Points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
