using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy_Z1 : MonoBehaviour
{
    [SerializeField] float lifetime = 4.2f; //ゲームオブジェクトの寿命 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, lifetime);
    }
}
