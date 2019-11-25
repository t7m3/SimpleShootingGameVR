using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加
using UnityEngine.VR;

//　デバグ用
using UnityEngine.UI;


//　デバグ用
//[RequireComponent(typeof(Text))]

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab; //弾のプレハブ
    [SerializeField] Transform gunBarrelEnd; //銃口（弾の発射位置）

    [SerializeField] Camera cam;


    //　デバグ用
    [SerializeField] Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        //　デバグ用
        uiText.text = "はじまり";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = gunBarrelEnd.position;
        uiText.text = string.Format("gunBarrelEndは x:{0:F}, y:{1:F}, z:{2:F}", p1.x, p1.y, p1.z);

        //入力に応じて弾を発射する
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {

        //Camera cam = Camera.main;

        //Vector3 p1 = new Vector3(0.0f,      // x
        //                         0.0f,      // y
        //                         0.0f);     // z    

        Vector3 p1 = gunBarrelEnd.position;
        //Quaternion r1 = gunBarrelEnd.rotation;
        Quaternion r1 = cam.transform.rotation;


        //Vector3 r1 = Camera.main.transform.rotation * Vector3.forward;
        //Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.rotation * Vector3.forward);

        //　デバグ用
        uiText.text = "shoot関数に来た";
        uiText.text = string.Format("ガンバレルエンドは x:{0:F}, y:{1:F}, z:{2:F}", p1.x, p1.y, p1.z);
        //Debug.Log("x = " + p1.x + "、y = " + p1.y + "、z = " + p1.z);

        //プレハブを元に、シーン上に弾を生成
        //Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);

        Instantiate(bulletPrefab, p1, r1);

    }
}
