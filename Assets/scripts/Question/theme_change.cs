using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

public class theme_change : MonoBehaviourPunCallbacks

{

    public PhotonView photonView;//pun使うために必用な奴

    public GameObject theme_canvas;

    public GameObject theme_button;

    public GameObject text;

    private bool tb;

    // Start is called before the first frame update
    void Start()
    {
        tb = false;
    }

    // Update is called once per frame
    void Update()
    {
        photonView.RPC(nameof(room_creator), RpcTarget.MasterClient);

        if (tb) theme_button.gameObject.SetActive(true);
        if (tb==false)
        {
            text.gameObject.SetActive(true);
            theme_button.gameObject.SetActive(false);
        }
        if (v.ep) theme_canvas.gameObject.SetActive(false);
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
        photonView.RPC(nameof(all_player_share), RpcTarget.All, player.ActorNumber);
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
    void all_player_share(int num)
    {
        v.all_player = num;
    }

    [PunRPC]
    void theme_set(string theme)
    {
        v.theme = theme;
    }





}
