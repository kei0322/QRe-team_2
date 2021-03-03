using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer_print : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "greatman") gm_text_switch();
        if (v.theme == "chaos") ch_text_switch();
    }

    private void gm_text_switch()
    {
        switch (v.choices)
        {
            case 0:
                if (v.answer == 0) { this.GetComponent<Text>().text = "織田信長"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "豊臣秀吉"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "徳川家康"; }
                break;
            case 1:
                if (v.answer == 0) { this.GetComponent<Text>().text = "西郷隆盛"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "坂本龍馬"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "沖田総司"; }
                break;
            case 2:
                if (v.answer == 0) { this.GetComponent<Text>().text = "エジソン"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ニコラ・テスラ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ライト兄弟"; }
                break;
            case 3:
                if (v.answer == 0) { this.GetComponent<Text>().text = "野口英世"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "樋口一葉"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "福沢諭吉"; }
                break;
            case 4:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ダーウィン"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ニュートン"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "アルキメデス"; }
                break;
            case 5:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ベートーヴェン"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "モーツァルト"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "バッハ"; }
                break;
            case 6:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ナポレオン"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "アレクサンドロス大王"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ラムセス2世"; }
                break;
            case 7:
                if (v.answer == 0) { this.GetComponent<Text>().text = "葛飾北斎"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "楊貴妃"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ゴッホ"; }
                break;
            case 8:
                if (v.answer == 0) { this.GetComponent<Text>().text = "芥川龍之介"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "太宰治"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "夏目漱石"; }
                break;
            case 9:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ソクラテス"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "フランシスコ・ザビエル"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ガンジー"; }
                break;
            case 10:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ジャンヌ・ダルク"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "清少納言"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ナイチンゲール"; }
                break;
            case 11:
                if (v.answer == 0) { this.GetComponent<Text>().text = "明智光秀"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "伊能忠敬"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "渋沢栄一"; }
                break;
            case 12:
                if (v.answer == 0) { this.GetComponent<Text>().text = "レオナルド・ダ・ヴィンチ"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ミケランジェロ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "アインシュタイン"; }
                break;
            case 13:
                if (v.answer == 0) { this.GetComponent<Text>().text = "チンギス・ハン"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "コロンブス"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "始皇帝"; }
                break;
            case 14:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ペリー"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "リンカーン"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ノーベル"; }
                break;
            case 15:
                if (v.answer == 0) { this.GetComponent<Text>().text = "滝廉太郎"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "シェイクスピア"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "アントニオ"; }
                break;
            case 16:
                if (v.answer == 0) { this.GetComponent<Text>().text = "カエサル"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "プラトン"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "源義経"; }
                break;
            default:
                break;
        }

    }

    private void ch_text_switch()
    {
        switch (v.choices)
        {
            case 0:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ブロッコリー"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ピーマン"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "きゅうり"; }
                break;
            case 1:
                if (v.answer == 0) { this.GetComponent<Text>().text = "キャベツ"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "レタス"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "白菜"; }
                break;
            case 2:
                if (v.answer == 0) { this.GetComponent<Text>().text = "トマト"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ジャガイモ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "パプリカ"; }
                break;
            case 3:
                if (v.answer == 0) { this.GetComponent<Text>().text = "小松菜"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "セロリ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "カリフラワー"; }
                break;
            case 4:
                if (v.answer == 0) { this.GetComponent<Text>().text = "トラ"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ライオン"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "チーター"; }
                break;
            case 5:
                if (v.answer == 0) { this.GetComponent<Text>().text = "牛"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "にわとり"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "豚"; }
                break;
            case 6:
                if (v.answer == 0) { this.GetComponent<Text>().text = "狐"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "狸"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ネズミ"; }
                break;
            case 7:
                if (v.answer == 0) { this.GetComponent<Text>().text = "車"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "自転車"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "バス"; }
                break;
            case 8:
                if (v.answer == 0) { this.GetComponent<Text>().text = "飛行機"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "電車"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "船"; }
                break;
            case 9:
                if (v.answer == 0) { this.GetComponent<Text>().text = "F1"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "バギー"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "バイク"; }
                break;
            case 10:
                if (v.answer == 0) { this.GetComponent<Text>().text = "ロードローラー"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "ショベルカー"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ブルドーザー"; }
                break;
            case 11:
                if (v.answer == 0) { this.GetComponent<Text>().text = "マグロ"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "鮭"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "イワシ"; }
                break;
            case 12:
                if (v.answer == 0) { this.GetComponent<Text>().text = "サメ"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "シーラカンス"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ふぐ"; }
                break;
            case 13:
                if (v.answer == 0) { this.GetComponent<Text>().text = "カブトムシ"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "クワガタムシ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "蝶"; }
                break;
            case 14:
                if (v.answer == 0) { this.GetComponent<Text>().text = "蜂"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "セミ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "アリ"; }
                break;
            case 15:
                if (v.answer == 0) { this.GetComponent<Text>().text = "野球"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "サッカー"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "剣道"; }
                break;
            case 16:
                if (v.answer == 0) { this.GetComponent<Text>().text = "バレー"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "バスケ"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "ラグビー"; }
                break;
            case 17:
                if (v.answer == 0) { this.GetComponent<Text>().text = "卓球"; }
                if (v.answer == 1) { this.GetComponent<Text>().text = "テニス"; }
                if (v.answer == 2) { this.GetComponent<Text>().text = "バトミントン"; }
                break;
            default:
                break;
        }
    }
}
