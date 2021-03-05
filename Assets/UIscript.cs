using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Realtime;

public class UIscript : MonoBehaviourPunCallbacks
{

    public GameObject nocon;

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        photonView.RPC(nameof(closepop), RpcTarget.All);
        //base.OnLeftRoom();
    }

    [PunRPC]
    void closepop()
    {
        nocon.gameObject.SetActive(true);
    }

    //　ログアウトボタンを押した時の処理
    public void LogoutGame()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("Lobby");
    }
}
