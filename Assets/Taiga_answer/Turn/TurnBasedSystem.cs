using System;
using System.Collections;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnBasedSystem : MonoBehaviourPunCallbacks, IPunTurnManagerCallbacks// このコールバックを使用する際は1，2，3，4，5を実装しなければならない
{
    [SerializeField]
    private RectTransform TimerFillImage;//タイマーの赤い部分
    [SerializeField]
    private Text TurnText;//ターン数の表示テキスト
    [SerializeField]
    private Text TimeText;//残り時間の表示テキスト
    private bool IsShowingResults;//真偽値

    [SerializeField]
    private GameObject answer;
    public GameObject button_set;
    public GameObject role_change_canvas;
    public GameObject theme_change_canvas;
    public GameObject questoner_canvas;
    public GameObject respondent_canvas;
    public GameObject turn_panel;

    private PunTurnManager turnManager;

    public Text correct_sum;
    public Text correct_rate;
    string correct_mes;

    public void Awake()
    {
        this.turnManager = this.gameObject.AddComponent<PunTurnManager>();//PunTurnManagerをコンポーネントに追加
        this.turnManager.TurnManagerListener = this;//リスナーを？
        this.turnManager.TurnDuration = 60f;//ターンは5秒にする
    }

    void Update()
    {
        //タイマーとターン数の処理
        //迂闊に弄らない方がよさげ
        if (this.TurnText != null)
        {
            this.TurnText.text = this.turnManager.Turn.ToString() + "回目の挑戦";//何ターン目かを表示してくれる
        }
        if (this.turnManager.Turn > 0 || this.TimeText != null && !IsShowingResults)//ターンが0以上、TimeTextがnullでない、結果が見えていない場合。
        {
            this.TimeText.text = this.turnManager.RemainingSecondsInTurn.ToString("0") + "秒";//残り時間を表示。
            TimerFillImage.anchorMax = new Vector2(1f - this.turnManager.RemainingSecondsInTurn / this.turnManager.TurnDuration, 1f);//残り時間のバーの表示。
        }


        //フラグ処理
        //加藤君の処理を参考にしたやつ
        //三人リトライボタン押したらフラグを立てる
        //フラグ処理は問題なし
        if (v.turn_sum >= v.all_player)
        {
            photonView.RPC(nameof(to_test_frag), RpcTarget.All);


        }

        //追加(2020/1/22)
        if (v.result_sum >= v.all_player)
        {
            photonView.RPC(nameof(to_result_frag), RpcTarget.All);
        }

        //フラグを立てたらこの処理を行う
        //直すならここかもポイント①
        if (v.turn_frag == true)
        {

            photonView.RPC(nameof(Reset), RpcTarget.All);//三人リトライボタン押したよっていう情報をリセット
            photonView.RPC(nameof(to_test_frag_false), RpcTarget.All);//立ってたフラグをへし折るよ
            //photonView.RPC(nameof(StartTurn), RpcTarget.All);//スタートターンの処理を全員で同期するよ
            photonView.RPC(nameof(panel_change), RpcTarget.All);//パネルの表示と非表示を行うよ
        }
    }

    public void OnPlayerFinished(Player player, int turn, object move)//1
    {
        //中身空白でいいからなんか書かなきゃいけない処理
    }

    public void OnPlayerMove(Player player, int turn, object move)//2
    {
        //同上
    }

    //ターンが始まったら・・・
    public void OnTurnBegins(int turn)//3
    {
        //始めは結果が見えないよ！
        //ターンが始まったらパネルを閉じるよ
        IsShowingResults = false;
        photonView.RPC(nameof(panel_false), RpcTarget.All);
        Debug.Log(turn);
    }

    //今回だと時間制限以外でターンを終わらせたらどうするかを記述
    //全員が解答選択し終えたら時間待たずに結果発表とかできるかも
    public void OnTurnCompleted(int obj)//4
    {


    }

    //今回だと制限時間が過ぎたらどうなるかを記述
    //直すならここかもポイント②
    [PunRPC]
    public void OnTurnTimeEnds(int turn)//5
    {
        //タイマーストップさせる処理
        //時間制限になった瞬間呼び出される処理(may be)
        //隠していた正解のパネルを表示
        answer.gameObject.SetActive(true);//追記 : ターン開始前に答えがチラチラ見える現象はここでパネルを表示しないようにすればいけるかもです
        button_set.gameObject.SetActive(true);
        Debug.Log(turn);//1回目[1]だった

        //正解したら
        if (v.answer == 0)
        {
            correct_sum.text = "正解者数は" + v.correct0 + "人!!";
            correct_rate.text = "演じた人の演技力は・・・" + correct_massege() + "級";
            Debug.Log("正解者数は" + v.correct0 + "人");
        }
        else if (v.answer == 1)
        {
            correct_sum.text = "正解者数は" + v.correct1 + "人!!";
            correct_rate.text = "演じた人の演技力は・・・" + correct_massege() + "級";
            Debug.Log("正解者数は" + v.correct1 + "人");
        }
        else if (v.answer == 2)
        {
            correct_sum.text = "正解者数は" + v.correct2 + "人!!";
            correct_rate.text = "演じた人の演技力は・・・" + correct_massege() + "級";
            Debug.Log("正解者数は" + v.correct2 + "人");
        }
    }

    [PunRPC]
    public void StartTurn()//ターン開始メソッド（シーン開始時にRPCから呼ばれる呼ばれるようにしてあります。）
    {
        if (PhotonNetwork.IsMasterClient)
        {
            this.turnManager.BeginTurn();//turnmanagerに新しいターンを始めさせる
            Debug.Log("スタートしたよ");
        }
    }

    [PunRPC]
    void to_test_frag()
    {
        v.turn_frag = true;

    }

    //追加(2020/1/22)
    [PunRPC]
    void to_result_frag()
    {
        v.result_frag = true;
    }

    [PunRPC]
    void to_test_frag_false()
    {
        v.turn_frag = false;
    }

    [PunRPC]
    void Reset()
    {
        v.turn_sum = 0;
        v.correct0 = 0;
        v.correct1 = 0;
        v.correct2 = 0;
        v.res_sum = 0;
        //Debug.Log("sumの合計は"+ v.turn_sum);
    }

    [PunRPC]
    void panel_false()
    {
        answer.gameObject.SetActive(false);
    }

    [PunRPC]
    void panel_change()
    {
        v.ep = false;
        role_change_canvas.gameObject.SetActive(true);
        theme_change_canvas.gameObject.SetActive(true);
    }

    [PunRPC]
    float correct_rate0()
    {
        float num0 = Mathf.Floor(1.0f * v.correct0 / v.res_sum * 100);     //切り捨て
        Debug.Log("正答率" + num0 + "%");
        return num0;
    }

    [PunRPC]
    float correct_rate1()
    {
        float num1 = Mathf.Floor(1.0f * v.correct1 / v.res_sum * 100);     //切り捨て
        Debug.Log("正答率" + num1 + "%");
        return num1;
    }

    [PunRPC]
    float correct_rate2()
    {
        float num2 = Mathf.Floor(1.0f * v.correct2 / v.res_sum * 100);     //切り捨て
        Debug.Log("正答率" + num2 + "%");
        return num2;
    }

    string correct_massege()
    {
        if (correct_rate0() == 100 || correct_rate1() == 100 || correct_rate2() == 100)
        {
            correct_mes = "人間国宝";
        }
        else if (correct_rate0() >= 60 || correct_rate1() >= 60 || correct_rate2() >= 60)
        {
            correct_mes = "ハリウッド";
        }
        else if (correct_rate0() >= 30 || correct_rate1() >= 30 || correct_rate2() >= 30)
        {
            correct_mes = "ベテラン";
        }
        else if (correct_rate0() >= 10 || correct_rate1() >= 10 || correct_rate2() >= 10)
        {
            correct_mes = "新人";
        }
        else if (correct_rate0() >= 0 || correct_rate1() >= 0 || correct_rate2() >= 0)
        {
            correct_mes = "凡人";
        }
        return correct_mes;
    }
}
