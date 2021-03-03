using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_text : MonoBehaviour
{
    public GameObject bt0;
    public GameObject bt1;
    public GameObject bt2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "greatman") gm_image_switch();
        if (v.theme == "chaos") ch_image_switch();
    }

    private void gm_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                bt0.GetComponent<Text>().text = "織田信長";
                bt1.GetComponent<Text>().text = "豊臣秀吉";
                bt2.GetComponent<Text>().text = "徳川家康";
                break;
            case 1:
                bt0.GetComponent<Text>().text = "西郷隆盛";
                bt1.GetComponent<Text>().text = "坂本龍馬";
                bt2.GetComponent<Text>().text = "沖田総司";
                break;
            case 2:
                bt0.GetComponent<Text>().text = "エジソン";
                bt1.GetComponent<Text>().text = "ニコラ・テスラ";
                bt2.GetComponent<Text>().text = "ライト兄弟";
                break;
            case 3:
                bt0.GetComponent<Text>().text = "野口英世";
                bt1.GetComponent<Text>().text = "樋口一葉";
                bt2.GetComponent<Text>().text = "福沢諭吉";
                break;
            case 4:
                bt0.GetComponent<Text>().text = "ダーウィン";
                bt1.GetComponent<Text>().text = "ニュートン";
                bt2.GetComponent<Text>().text = "アルキメデス";
                break;
            case 5:
                bt0.GetComponent<Text>().text = "ベートーヴェン";
                bt1.GetComponent<Text>().text = "モーツァルト";
                bt2.GetComponent<Text>().text = "バッハ";
                break;
            case 6:
                bt0.GetComponent<Text>().text = "ナポレオン";
                bt1.GetComponent<Text>().text = "アレクサンドロス大王";
                bt2.GetComponent<Text>().text = "ラムセス2世";
                break;
            case 7:
                bt0.GetComponent<Text>().text = "葛飾北斎";
                bt1.GetComponent<Text>().text = "楊貴妃";
                bt2.GetComponent<Text>().text = "ゴッホ";
                break;
            case 8:
                bt0.GetComponent<Text>().text = "芥川龍之介";
                bt1.GetComponent<Text>().text = "太宰治";
                bt2.GetComponent<Text>().text = "夏目漱石";
                break;
            case 9:
                bt0.GetComponent<Text>().text = "ソクラテス";
                bt1.GetComponent<Text>().text = "フランシスコ・ザビエル";
                bt2.GetComponent<Text>().text = "ガンジー";
                break;
            case 10:
                bt0.GetComponent<Text>().text = "ジャンヌ・ダルク";
                bt1.GetComponent<Text>().text = "清少納言";
                bt2.GetComponent<Text>().text = "ナイチンゲール";
                break;
            case 11:
                bt0.GetComponent<Text>().text = "明智光秀";
                bt1.GetComponent<Text>().text = "伊能忠敬";
                bt2.GetComponent<Text>().text = "渋沢栄一";
                break;
            case 12:
                bt0.GetComponent<Text>().text = "レオナルド・ダ・ヴィンチ";
                bt1.GetComponent<Text>().text = "ミケランジェロ";
                bt2.GetComponent<Text>().text = "アインシュタイン";
                break;
            case 13:
                bt0.GetComponent<Text>().text = "チンギス・ハン";
                bt1.GetComponent<Text>().text = "コロンブス";
                bt2.GetComponent<Text>().text = "始皇帝";
                break;
            case 14:
                bt0.GetComponent<Text>().text = "ペリー";
                bt1.GetComponent<Text>().text = "リンカーン";
                bt2.GetComponent<Text>().text = "ノーベル";
                break;
            case 15:
                bt0.GetComponent<Text>().text = "滝廉太郎";
                bt1.GetComponent<Text>().text = "シェイクスピア";
                bt2.GetComponent<Text>().text = "アントニオ";
                break;
            case 16:
                bt0.GetComponent<Text>().text = "カエサル";
                bt1.GetComponent<Text>().text = "プラトン";
                bt2.GetComponent<Text>().text = "源義経";
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
                bt0.GetComponent<Text>().text = "ブロッコリー";
                bt1.GetComponent<Text>().text = "ピーマン";
                bt2.GetComponent<Text>().text = "きゅうり";
                break;
            case 1:
                bt0.GetComponent<Text>().text = "キャベツ";
                bt1.GetComponent<Text>().text = "レタス";
                bt2.GetComponent<Text>().text = "白菜";
                break;
            case 2:
                bt0.GetComponent<Text>().text = "トマト";
                bt1.GetComponent<Text>().text = "ジャガイモ";
                bt2.GetComponent<Text>().text = "パプリカ";
                break;
            case 3:
                bt0.GetComponent<Text>().text = "小松菜";
                bt1.GetComponent<Text>().text = "セロリ";
                bt2.GetComponent<Text>().text = "カリフラワー";
                break;
            case 4:
                bt0.GetComponent<Text>().text = "トラ";
                bt1.GetComponent<Text>().text = "ライオン";
                bt2.GetComponent<Text>().text = "チーター";
                break;
            case 5:
                bt0.GetComponent<Text>().text = "牛";
                bt1.GetComponent<Text>().text = "にわとり";
                bt2.GetComponent<Text>().text = "豚";
                break;
            case 6:
                bt0.GetComponent<Text>().text = "狐";
                bt1.GetComponent<Text>().text = "狸";
                bt2.GetComponent<Text>().text = "ネズミ";
                break;
            case 7:
                bt0.GetComponent<Text>().text = "車";
                bt1.GetComponent<Text>().text = "自転車";
                bt2.GetComponent<Text>().text = "バス";
                break;
            case 8:
                bt0.GetComponent<Text>().text = "飛行機";
                bt1.GetComponent<Text>().text = "電車";
                bt2.GetComponent<Text>().text = "船";
                break;
            case 9:
                bt0.GetComponent<Text>().text = "F1";
                bt1.GetComponent<Text>().text = "バギー";
                bt2.GetComponent<Text>().text = "バイク";
                break;
            case 10:
                bt0.GetComponent<Text>().text = "ロードローラー";
                bt1.GetComponent<Text>().text = "ショベルカー";
                bt2.GetComponent<Text>().text = "ブルドーザー";
                break;
            case 11:
                bt0.GetComponent<Text>().text = "マグロ";
                bt1.GetComponent<Text>().text = "鮭";
                bt2.GetComponent<Text>().text = "イワシ";
                break;
            case 12:
                bt0.GetComponent<Text>().text = "サメ";
                bt1.GetComponent<Text>().text = "シーラカンス";
                bt2.GetComponent<Text>().text = "ふぐ";
                break;
            case 13:
                bt0.GetComponent<Text>().text = "カブトムシ";
                bt1.GetComponent<Text>().text = "クワガタムシ";
                bt2.GetComponent<Text>().text = "蝶";
                break;
            case 14:
                bt0.GetComponent<Text>().text = "蜂";
                bt1.GetComponent<Text>().text = "セミ";
                bt2.GetComponent<Text>().text = "アリ";
                break;
            case 15:
                bt0.GetComponent<Text>().text = "野球";
                bt1.GetComponent<Text>().text = "サッカー";
                bt2.GetComponent<Text>().text = "剣道";
                break;
            case 16:
                bt0.GetComponent<Text>().text = "バレー";
                bt1.GetComponent<Text>().text = "バスケ";
                bt2.GetComponent<Text>().text = "ラグビー";
                break;
            case 17:
                bt0.GetComponent<Text>().text = "卓球";
                bt1.GetComponent<Text>().text = "テニス";
                bt2.GetComponent<Text>().text = "バトミントン";
                break;

            default:
                break;
        }

    }
}
