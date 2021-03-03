using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonControl : MonoBehaviourPunCallbacks
{
    //public PhotonView photonView;

    public GameObject button_set;
    public GameObject button_set1;


    public void select()
    {
        button_set.gameObject.SetActive(false);
        photonView.RPC(nameof(ansum_share), RpcTarget.All);
       
    }

    // 2020/2/22追記
    public void result()
    {
        button_set1.gameObject.SetActive(false);
        photonView.RPC(nameof(result_share), RpcTarget.All);
    }

    [PunRPC]
    void ansum_share()
    {
        v.turn_sum++;
    }

    // 2020/2/22追記
    [PunRPC]
    public void result_share()
    {
        v.result_sum++;
    }
}