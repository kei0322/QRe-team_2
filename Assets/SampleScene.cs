using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// MonoBehaviourではなくMonoBehaviourPunCallbacksを継承して、Photonのコールバックを受け取れるようにする
public class SampleScene : MonoBehaviourPunCallbacks
{
    public GameObject[] CubePrefabs; //オブジェクトを格納する配列変数
    private int number; //ランダム情報を入れるための変数
                        //誰かがログインする度に生成するプレイヤーPrefab
                        // public GameObject playerPrefab;

    void Start()
    {
        //Photonに接続していれば自プレイヤーを生成
        number = Random.Range(0, CubePrefabs.Length); //Random.Range (最小値, 最大値) 整数の場合は最大値は除外
        GameObject Player = PhotonNetwork.Instantiate(this.CubePrefabs[number].name, new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
    }
}