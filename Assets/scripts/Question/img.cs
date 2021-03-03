using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;//UIであるImageを使用するので追加する
using UnityEngine.SceneManagement;

public class img : MonoBehaviourPunCallbacks
{
    public PhotonView photonView;//pun使うために必用な奴

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
        
        
        //photonView.RPC(nameof(SendChatMessage), RpcTarget.Others, "よろしくお願いします");
    }

    private void gm_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                img0.sprite = greatman0;
                img1.sprite = greatman1;
                img2.sprite = greatman2;
                break;
            default:
                img0.sprite = def;
                img1.sprite = def;
                img2.sprite = def;
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
