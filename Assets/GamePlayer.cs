using Photon.Pun;
using UnityEngine;
using TMPro;

// MonoBehaviourPunCallbacksを継承すると、photonViewプロパティが使えるようになる
public class GamePlayer : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TextMeshPro nameLabel = default;
    private void Start()
    {
        nameLabel.text = photonView.Owner.NickName;
    }

    private void Update()
    {
        // 自身が生成したオブジェクトだけに移動処理を行う
        if (photonView.IsMine)
        {
            // var dx = 0.1f * Input.GetAxis("Horizontal");
            //  var dy = 0.1f * Input.GetAxis("Vertical");
            // transform.Translate(dx, dy, 0f);
            Vector3 mpos = Input.mousePosition;
            mpos.z = -Camera.main.transform.position.z;
            Vector3 wpos = Camera.main.ScreenToWorldPoint(mpos);
            transform.position = wpos;
        }
    }
}