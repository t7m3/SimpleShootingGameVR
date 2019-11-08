using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//　デバグ用
using UnityEngine.UI;

public class cameraPosition : MonoBehaviour
{

    //　デバグ用
    [SerializeField] Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = transform.position;
        Quaternion r1 = transform.rotation;

        //uiText.text = string.Format("ここでは x:{0:F}, y:{1:F}, z:{2:F}", p1.x, p1.y, p1.z);
        uiText.text = string.Format("ここでは x:{0:F}, y:{1:F}, z:{2:F}", r1.x, r1.y, r1.z);

    }
}
