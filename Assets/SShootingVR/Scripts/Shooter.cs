using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab; //弾のプレハブ
    [SerializeField] Transform gunBarrelEnd; //銃口（弾の発射位置）

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //入力に応じて弾を発射する
        if (Input.GetButtonDown("Fire1"))
            Shoot();

    }

    void Shoot()
    {
        //プレハブを元に、シーン上に弾を生成
        Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);

    }
}
