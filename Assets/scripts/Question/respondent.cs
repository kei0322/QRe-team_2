using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;//UIであるImageを使用するので追加する
using UnityEngine.SceneManagement;

public class respondent : MonoBehaviourPunCallbacks
{
    //public PhotonView photonView;//pun使うために必用な奴

    public Image img0;//左の画像
    public Image img1;//真ん中の画像
    public Image img2;//右の画像

    public Sprite def;//何もはまらなかった時の画像

    //偉人
    public Sprite greatman0;
    public Sprite greatman1;
    public Sprite greatman2;

    //共有変数
    //private string theme;
    //private int choices = 0;
    //private bool ttf=false;


    private void Start()
    {

        //v.theme = "greatman";
    }

    // Update is called once per frame
    private void Update()
    {
        if (v.theme == "greatman") gm_image_switch();
        if (v.theme == "chaos") ch_image_switch();

        if (v.ansum >= v.player_count) photonView.RPC(nameof(to_test_frag), RpcTarget.All);
        //現状Answerシーンに飛ぶ必要がないのでコメントアウトしています 岩下
        //if (v.ttf == true) SceneManager.LoadScene("Answer");
        //photonView.RPC(nameof(SendChatMessage), RpcTarget.Others, "よろしくお願いします");
    }

    private void gm_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                img0.sprite = Resources.Load<Sprite>("images/greatman/nobunaga");
                img1.sprite = Resources.Load<Sprite>("images/greatman/hideyosi");
                img2.sprite = Resources.Load<Sprite>("images/greatman/ieyasu");
                break;
            case 1:
                img0.sprite = Resources.Load<Sprite>("images/greatman/saigoutakamori");
                img1.sprite = Resources.Load<Sprite>("images/greatman/sakamotoryouma");
                img2.sprite = Resources.Load<Sprite>("images/greatman/okitasousi");
                break;
            case 2:
                img0.sprite = Resources.Load<Sprite>("images/greatman/ezisonn");
                img1.sprite = Resources.Load<Sprite>("images/greatman/nikoratesura");
                img2.sprite = Resources.Load<Sprite>("images/greatman/raitokyoudai");
                break;
            case 3:
                img0.sprite = Resources.Load<Sprite>("images/greatman/nogutihideo");
                img1.sprite = Resources.Load<Sprite>("images/greatman/higutiiyou");
                img2.sprite = Resources.Load<Sprite>("images/greatman/hukuzawayukiti");
                break;
            case 4:
                img0.sprite = Resources.Load<Sprite>("images/greatman/da-winn");
                img1.sprite = Resources.Load<Sprite>("images/greatman/nyu-tonn");
                img2.sprite = Resources.Load<Sprite>("images/greatman/arukimedesu");
                break;
            case 5:
                img0.sprite = Resources.Load<Sprite>("images/greatman/be-to-benn");
                img1.sprite = Resources.Load<Sprite>("images/greatman/mo-tuxaruto");
                img2.sprite = Resources.Load<Sprite>("images/greatman/bahha");
                break;
            case 6:
                img0.sprite = Resources.Load<Sprite>("images/greatman/naporeonn");
                img1.sprite = Resources.Load<Sprite>("images/greatman/arekusanndorosudaiou");
                img2.sprite = Resources.Load<Sprite>("images/greatman/ramusesunisei");
                break;
            case 7:
                img0.sprite = Resources.Load<Sprite>("images/greatman/katusikahokusai");
                img1.sprite = Resources.Load<Sprite>("images/greatman/youkimi");
                img2.sprite = Resources.Load<Sprite>("images/greatman/gohho");
                break;
            case 8:
                img0.sprite = Resources.Load<Sprite>("images/greatman/akutagawaryuunosuke");
                img1.sprite = Resources.Load<Sprite>("images/greatman/dazaiosamu");
                img2.sprite = Resources.Load<Sprite>("images/greatman/natumesouseki");
                break;
            case 9:
                img0.sprite = Resources.Load<Sprite>("images/greatman/sokuratesu");
                img1.sprite = Resources.Load<Sprite>("images/greatman/hurannsisukozabieru");
                img2.sprite = Resources.Load<Sprite>("images/greatman/gannzi-");
                break;
            case 10:
                img0.sprite = Resources.Load<Sprite>("images/greatman/zyannnudaruku");
                img1.sprite = Resources.Load<Sprite>("images/greatman/seisyounagonn");
                img2.sprite = Resources.Load<Sprite>("images/greatman/naitinnge-ru");
                break;
            case 11:
                img0.sprite = Resources.Load<Sprite>("images/greatman/aketimituhide");
                img1.sprite = Resources.Load<Sprite>("images/greatman/inoutatdataka");
                img2.sprite = Resources.Load<Sprite>("images/greatman/sibusawaeiiti");
                break;
            case 12:
                img0.sprite = Resources.Load<Sprite>("images/greatman/davinnti");
                img1.sprite = Resources.Load<Sprite>("images/greatman/mikerannzyaro");
                img2.sprite = Resources.Load<Sprite>("images/greatman/ainnsyutainn");
                break;
            case 13:
                img0.sprite = Resources.Load<Sprite>("images/greatman/tinngisuhann");
                img1.sprite = Resources.Load<Sprite>("images/greatman/koronnbusu");
                img2.sprite = Resources.Load<Sprite>("images/greatman/sikoutei");
                break;
            case 14:
                img0.sprite = Resources.Load<Sprite>("images/greatman/peri-");
                img1.sprite = Resources.Load<Sprite>("images/greatman/rinnka-");
                img2.sprite = Resources.Load<Sprite>("images/greatman/no-beru");
                break;
            case 15:
                img0.sprite = Resources.Load<Sprite>("images/greatman/takirenntarou");
                img1.sprite = Resources.Load<Sprite>("images/greatman/syaikusupia");
                img2.sprite = Resources.Load<Sprite>("images/greatman/anntonio");
                break;
            case 16:
                img0.sprite = Resources.Load<Sprite>("images/greatman/kaesaru");
                img1.sprite = Resources.Load<Sprite>("images/greatman/puratonn");
                img2.sprite = Resources.Load<Sprite>("images/greatman/minamotonoyositune");
                break;
            default:
                break;
        }

    }

    private void ch_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                img0.sprite = Resources.Load<Sprite>("images/chaos/burokkori-");
                img1.sprite = Resources.Load<Sprite>("images/chaos/pi-mnn");
                img2.sprite = Resources.Load<Sprite>("images/chaos/kyuuri");
                break;
            case 1:
                img0.sprite = Resources.Load<Sprite>("images/chaos/kyabetu");
                img1.sprite = Resources.Load<Sprite>("images/chaos/retasu");
                img2.sprite = Resources.Load<Sprite>("images/chaos/hakusai");
                break;
            case 2:
                img0.sprite = Resources.Load<Sprite>("images/chaos/tomato");
                img1.sprite = Resources.Load<Sprite>("images/chaos/jagaimo");
                img2.sprite = Resources.Load<Sprite>("images/chaos/papurika");
                break;
            case 3:
                img0.sprite = Resources.Load<Sprite>("images/chaos/komatuna");
                img1.sprite = Resources.Load<Sprite>("images/chaos/serori");
                img2.sprite = Resources.Load<Sprite>("images/chaos/karihurawa-");
                break;
            case 4:
                img0.sprite = Resources.Load<Sprite>("images/chaos/tora");
                img1.sprite = Resources.Load<Sprite>("images/chaos/raionn");
                img2.sprite = Resources.Load<Sprite>("images/chaos/ti-ta-");
                break;
            case 5:
                img0.sprite = Resources.Load<Sprite>("images/chaos/usi");
                img1.sprite = Resources.Load<Sprite>("images/chaos/niwatori");
                img2.sprite = Resources.Load<Sprite>("images/chaos/buta");
                break;
            case 6:
                img0.sprite = Resources.Load<Sprite>("images/chaos/kitune");
                img1.sprite = Resources.Load<Sprite>("images/chaos/tanuki");
                img2.sprite = Resources.Load<Sprite>("images/chaos/nezumi");
                break;
            case 7:
                img0.sprite = Resources.Load<Sprite>("images/chaos/kuruma");
                img1.sprite = Resources.Load<Sprite>("images/chaos/zitennsya");
                img2.sprite = Resources.Load<Sprite>("images/chaos/basu");
                break;
            case 8:
                img0.sprite = Resources.Load<Sprite>("images/chaos/hikouki");
                img1.sprite = Resources.Load<Sprite>("images/chaos/dennsya");
                img2.sprite = Resources.Load<Sprite>("images/chaos/hune");
                break;
            case 9:
                img0.sprite = Resources.Load<Sprite>("images/chaos/f1");
                img1.sprite = Resources.Load<Sprite>("images/chaos/bagi-");
                img2.sprite = Resources.Load<Sprite>("images/chaos/baiku");
                break;
            case 10:
                img0.sprite = Resources.Load<Sprite>("images/chaos/ro-doro-ra-");
                img1.sprite = Resources.Load<Sprite>("images/chaos/syoberuka-");
                img2.sprite = Resources.Load<Sprite>("images/chaos/burudo-za-");
                break;
            case 11:
                img0.sprite = Resources.Load<Sprite>("images/chaos/maguro");
                img1.sprite = Resources.Load<Sprite>("images/chaos/sake");
                img2.sprite = Resources.Load<Sprite>("images/chaos/iwasi");
                break;
            case 12:
                img0.sprite = Resources.Load<Sprite>("images/chaos/same");
                img1.sprite = Resources.Load<Sprite>("images/chaos/si-rakannsu");
                img2.sprite = Resources.Load<Sprite>("images/chaos/hugu");
                break;
            case 13:
                img0.sprite = Resources.Load<Sprite>("images/chaos/kabutomusi");
                img1.sprite = Resources.Load<Sprite>("images/chaos/kuwagatamusi");
                img2.sprite = Resources.Load<Sprite>("images/chaos/cyou");
                break;
            case 14:
                img0.sprite = Resources.Load<Sprite>("images/chaos/hati");
                img1.sprite = Resources.Load<Sprite>("images/chaos/semi");
                img2.sprite = Resources.Load<Sprite>("images/chaos/ari");
                break;
            case 15:
                img0.sprite = Resources.Load<Sprite>("images/chaos/yakyuu");
                img1.sprite = Resources.Load<Sprite>("images/chaos/sakka-");
                img2.sprite = Resources.Load<Sprite>("images/chaos/kenndou");
                break;
            case 16:
                img0.sprite = Resources.Load<Sprite>("images/chaos/bare-");
                img1.sprite = Resources.Load<Sprite>("images/chaos/basuke");
                img2.sprite = Resources.Load<Sprite>("images/chaos/ragubi-");
                break;
            case 17:
                img0.sprite = Resources.Load<Sprite>("images/chaos/takkyuu");
                img1.sprite = Resources.Load<Sprite>("images/chaos/tenisu");
                img2.sprite = Resources.Load<Sprite>("images/chaos/batominntonn");
                break;
            default:
                break;
        }

    }

    [PunRPC]
    void to_test_frag()
    {
        v.ttf = true;
    }

    [PunRPC]
    private void SendChatMessage(string message)
    {
        Debug.Log(message);
    }
}
