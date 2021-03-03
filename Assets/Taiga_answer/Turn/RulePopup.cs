using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulePopup : MonoBehaviour
{
    public Button RuleButton;//ルール説明表示ボタン
    public GameObject Popup;//ルール説明ウィンドウ

    /*void Start()
    {
        
    }

    void Update()
    {

    }*/

    //ルール説明表示ボタンを押した時の処理
    public void OnClick_RuleButton()
    {
        //ルール説明ウインドウが表示していれば
        if (Popup.activeSelf)
        {
            //ルール説明ウィンドウを非表示
            Popup.SetActive(false);
        }
        else//そうでなければ
        {
            //ルール説明ウィンドウを表示
            Popup.SetActive(true);
        }
    }
}
