using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float lifetime = 5f; //ゲームオブジェクトの寿命 

    // Start is called before the first frame update
    void Start()
    {
        //一定時間経過後にゲームオブジェクトを破棄する
        //Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
