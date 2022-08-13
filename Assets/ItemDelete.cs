using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        if (unitychan.transform.position.z - 6f >this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
