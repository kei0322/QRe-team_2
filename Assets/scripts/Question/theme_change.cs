using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;

public class theme_change : MonoBehaviourPunCallbacks

{

    public PhotonView photonView;//pun使うために必用な奴

    public GameObject theme_canvas;

    public GameObject theme_button;

    public GameObject text;

    private bool tb;
    private int pn;
    private Room pc;

    public GameObject matchingtext;
    public Text matchingnum;

    // Start is called before the first frame update
    void Start()
    {
        tb = false;
        pn = 0;
        v.ep = false;
        pc = PhotonNetwork.CurrentRoom;
        matchingtext.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        v.all_player = pc.PlayerCount;
        matchingnum.text = pc.MaxPlayers +"人中" + pc.PlayerCount + "人が集まりました";
        photonView.RPC(nameof(room_creator), RpcTarget.MasterClient);
        if (pc.PlayerCount == pc.MaxPlayers)
        {
            matchingtext.gameObject.SetActive(false);
            pc.IsVisible = false;
            if (tb)
            {
                theme_button.gameObject.SetActive(true);
                text.gameObject.SetActive(false);
            }
            if (tb == false)
            {
                text.gameObject.SetActive(true);
                theme_button.gameObject.SetActive(false);
            }
            if (v.ep) theme_canvas.gameObject.SetActive(false);
        }
       
        Debug.Log("参加者数 : " + pc.PlayerCount + "/最大人数 : " + pc.MaxPlayers);
        Debug.Log("v.allplayer : " + v.all_player);
    }

    public void greatman()
    {
        //v.theme = "greatman";
        photonView.RPC(nameof(theme_set), RpcTarget.All, "greatman");
        photonView.RPC(nameof(erase_panel), RpcTarget.All);
    }

    public void chaos()
    {
        //v.theme = "chaos";
        photonView.RPC(nameof(theme_set), RpcTarget.All, "chaos");
        photonView.RPC(nameof(erase_panel), RpcTarget.All);
    }

    public override void OnJoinedRoom()
    {
        Room myroom = PhotonNetwork.CurrentRoom;　//myroom変数にPhotonnetworkの部屋の現在状況を入れる。
        Photon.Realtime.Player player = PhotonNetwork.LocalPlayer;　//playerをphotonnetworkのローカルプレイヤーとする
        Debug.Log("ルーム名:" + myroom.Name);
        Debug.Log("PlayerNo" + player.ActorNumber);
        Debug.Log("プレイヤーID" + player.UserId);
        //photonView.RPC(nameof(all_player_share), RpcTarget.All, player.ActorNumber);
    }

    [PunRPC]
    void room_creator()
    {
        tb = true;
    }

    [PunRPC]
    void erase_panel()
    {
        v.ep = true;
    }

    [PunRPC]
    void theme_set(string theme)
    {
        v.theme = theme;
    }


   



}
