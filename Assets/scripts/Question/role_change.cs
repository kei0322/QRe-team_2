using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Photon使うときは必ずオブジェクトにPhoton Viewをつけること！
using Photon.Pun;

public class role_change : MonoBehaviourPunCallbacks
{
    //岩下
    //加藤君が作ってくれたものにかなり手を加えてます
    //具体的にタイマースタートを同期させるためにいろいろ付け加えてます
    //やってる処理は解答・出題を選択→全員が選択し終わるまで待機→全員が選択し終わったらタイマースタート&問題表示→結果発表→最初の役割選択画面に戻る

    public GameObject role_change_canvas;
    public GameObject questoner_canvas;
    public GameObject respondent_canvas;
    public GameObject button_canvas;//回答者のボタン
    public GameObject button_role_0;//ロール選択のボタン0
    public GameObject button_role_1;//ロール選択のボタン1
    public GameObject wait_text;//待機中のメッセージ
    public GameObject timer;
    public GameObject scripts;

    private int ans;
    private int cho;

    button reset;
    // Start is called before the first frame update
    void Awake()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (v.select_sum >= v.all_player)
        {

            photonView.RPC(nameof(to_wait_frag), RpcTarget.All);
        }

        if (v.wait_frag == true)
        {
            //*** パネルを開けてからタイマーの処理を開始するので順番変えない***//
            photonView.RPC(nameof(wait_reset), RpcTarget.All);//フラグリセット
            photonView.RPC(nameof(role_panel_change), RpcTarget.All);//パネルの表示と非表示を行うよ
            photonView.RPC(nameof(RoleStartTurn), RpcTarget.All);//スタートターンの処理を全員で同期するよ
        }
    }

    public void respondent()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(true);
        photonView.RPC(nameof(ressum), RpcTarget.All);
        Debug.Log("回答者を選択します");
    }

    public void questoner()
    {
        ans = (int)Random.Range(0.0f, 3.0f);//三人の中から答えとなる人を一人選ぶ
        cho = (int)Random.Range(0.0f, 18.0f);//いっぱいの中からクイズのセットを選ぶ
        //ans = 2;
        photonView.RPC(nameof(answer_share), RpcTarget.All, ans);//全員の答えとなる人を0番(1番左)に設定する

        photonView.RPC(nameof(choices_share), RpcTarget.All, cho);

        respondent_canvas.gameObject.SetActive(true);
        respondent_canvas.gameObject.SetActive(false);
        questoner_canvas.gameObject.SetActive(true);
        Debug.Log("出題者を選択します");
    }

    //選択で共通すること
    public void select_role()
    {
        photonView.RPC(nameof(wait_share), RpcTarget.All);
        //選択ボタン消去&待機メッセージ表示
        button_role_0.gameObject.SetActive(false);
        button_role_1.gameObject.SetActive(false);
        wait_text.gameObject.SetActive(true);
    }

    [PunRPC]
    void wait_share()
    {
        v.select_sum++;
        Debug.Log(v.select_sum);
    }

    [PunRPC]
    void to_wait_frag()
    {
        v.wait_frag = true;
    }



    [PunRPC]
    void role_panel_change()
    {
        timer.gameObject.SetActive(true);
        Invoke("close_chanvas", 0.3f);
    }

    [PunRPC]
    void RoleStartTurn()
    {
        scripts.GetComponent<TurnBasedSystem>().StartTurn();
    }

    [PunRPC]
    void wait_reset()
    {
        v.select_sum = 0;
        v.wait_frag = false;
    }

    //ロールチェンジキャンバスの遅延処理
    void close_chanvas()
    {
        button_canvas.gameObject.SetActive(true);
        button_role_0.gameObject.SetActive(true);
        button_role_1.gameObject.SetActive(true);
        wait_text.gameObject.SetActive(false);
        role_change_canvas.gameObject.SetActive(false);
    }

    [PunRPC]
    void ressum()
    {
        v.res_sum++;
    }

    [PunRPC]
    void answer_share(int ans)
    {
        v.answer = ans;
    }

    [PunRPC]
    void choices_share(int c)
    {
        v.choices = c;
    }
}
