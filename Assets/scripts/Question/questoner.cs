using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questoner : MonoBehaviourPunCallbacks
{
    //public PhotonView photonView;

    public Image img;//左の画像

    public Text name;
    public Text description;

    //偉人
    //public Sprite greatman0;
    //public Sprite greatman1;
    //public Sprite greatman2;

    //共有変数
    //private string theme="greatman";
    //private int choices = 0;
    //private int answer = 0;
    //private bool ttf = false;

    // Start is called before the first frame update
    void Start()
    {
        //v.answer = (int)Random.Range(0.0f, 3.0f);
        Debug.Log(v.answer);
    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "greatman") gm_image_switch();
        if (v.theme == "chaos") ch_image_switch();
        if (v.ansum >= v.player_count) photonView.RPC(nameof(to_test_frag), RpcTarget.All);
        //現状Answerシーンに飛ぶ必要がないのでコメントアウトしています 岩下
        //if (v.ttf == true) SceneManager.LoadScene("Answer");
    }

    private void gm_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/nobunaga"); name.GetComponent<Text>().text = "織田信長"; description.GetComponent<Text>().text = "・鳴かぬなら\n・うつけ\n・楽市楽座\n・火縄銃\n・天下布武\n・人間五十年"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/hideyosi"); name.GetComponent<Text>().text = "豊臣秀吉"; description.GetComponent<Text>().text = "・猿\n・刀狩り\n・水攻め\n・天下統一"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/ieyasu"); name.GetComponent<Text>().text = "徳川家康"; description.GetComponent<Text>().text = "・狸\n・幕府\n・関ヶ原\n・江戸"; }
                break;
            case 1:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/saigoutakamori"); name.GetComponent<Text>().text = "西郷隆盛"; description.GetComponent<Text>().text = "・薩摩\n・銅像\n・犬"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/sakamotoryouma"); name.GetComponent<Text>().text = "坂本龍馬"; description.GetComponent<Text>().text = "・幕末\n・大政奉還\n・お龍"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/okitasousi"); name.GetComponent<Text>().text = "沖田総司"; description.GetComponent<Text>().text = "・新選組\n・三段突き\n・病弱"; }
                break;
            case 2:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/ezisonn"); name.GetComponent<Text>().text = "エジソン"; description.GetComponent<Text>().text = "・発明\n・電話\n・電球\n蓄音機"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/nikoratesura"); name.GetComponent<Text>().text = "ニコラ・テスラ"; description.GetComponent<Text>().text = "・発明\n・電気\n・交流"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/raitokyoudai"); name.GetComponent<Text>().text = "ライト兄弟"; description.GetComponent<Text>().text = "・アメリカ\n・名前はウィルバーとオーヴィル\n・飛行機"; }
                break;
            case 3:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/nogutihideo"); name.GetComponent<Text>().text = "野口英世"; description.GetComponent<Text>().text = "・千円札\n・囲炉裏\n・黄熱病\n・旧名は「清作」"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/higutiiyou"); name.GetComponent<Text>().text = "樋口一葉"; description.GetComponent<Text>().text = "・五千円札\n・小説家\n・たけくらべ"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/hukuzawayukiti"); name.GetComponent<Text>().text = "福沢諭吉"; description.GetComponent<Text>().text = "・一万円札\n・慶應義塾\n・学問のすゝめ"; }
                break;
            case 4:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/da-winn"); name.GetComponent<Text>().text = "ダーウィン"; description.GetComponent<Text>().text = "・自然科学者\n・種の起源\n・進化論\n"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/nyu-tonn"); name.GetComponent<Text>().text = "ニュートン"; description.GetComponent<Text>().text = "・万有引力\n・リンゴ\n・運動量保存の法則"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/arukimedesu"); name.GetComponent<Text>().text = "アルキメデス"; description.GetComponent<Text>().text = "・ギリシャ\n・数学者\n・てこの原理"; }
                break;
            case 5:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/be-to-benn"); name.GetComponent<Text>().text = "ベートーヴェン"; description.GetComponent<Text>().text = "・音楽家\n・難聴\n・楽聖\n・いかつい肖像画\n・運命"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/mo-tuxaruto"); name.GetComponent<Text>().text = "モーツァルト"; description.GetComponent<Text>().text = "・音楽家\n・神童\n・トルコ行進曲\n・怒りの日"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/bahha"); name.GetComponent<Text>().text = "バッハ"; description.GetComponent<Text>().text = "・ドイツ\n・音楽家\n・音楽の父\n・トッカータとフーガ"; }
                break;
            case 6:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/naporeonn"); name.GetComponent<Text>().text = "ナポレオン"; description.GetComponent<Text>().text = "・フランス\n・帽子\n・馬"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/arekusanndorosudaiou"); name.GetComponent<Text>().text = "アレクサンドロス大王"; description.GetComponent<Text>().text = "・ギリシャ\n・ダレイオス三世と戦った\n・ブケファラス\n・「イスカンダル」ともいう"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/ramusesunisei"); name.GetComponent<Text>().text = "ラムセス2世"; description.GetComponent<Text>().text = "・エジプト\n・3代目ファラオ\n・「オジマンディアス」ともいう"; }
                break;
            case 7:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/katusikahokusai"); name.GetComponent<Text>().text = "葛飾北斎"; description.GetComponent<Text>().text = "・画家\n・富嶽三十六景\n・引っ越し"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/youkimi"); name.GetComponent<Text>().text = "楊貴妃"; description.GetComponent<Text>().text = "・中国\n・傾国の美女\n・世界三大美人"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/gohho"); name.GetComponent<Text>().text = "ゴッホ"; description.GetComponent<Text>().text = "・オランダ\n・画家\n・生前は売れなかった\n・星月夜\n・向日葵"; }
                break;
            case 8:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/akutagawaryuunosuke"); name.GetComponent<Text>().text = "芥川龍之介"; description.GetComponent<Text>().text = "・小説家\n・羅生門\n・地獄変\n・日本"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/dazaiosamu"); name.GetComponent<Text>().text = "太宰治"; description.GetComponent<Text>().text = "・小説家\n・人間失格\n・走れメロス\n・日本"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/natumesouseki"); name.GetComponent<Text>().text = "夏目漱石"; description.GetComponent<Text>().text = "・小説家\n・吾輩は猫である\n・坊っちゃん"; }
                break;
            case 9:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/sokuratesu"); name.GetComponent<Text>().text = "ソクラテス"; description.GetComponent<Text>().text = "・哲学者\n・ギリシャ\n・四聖人"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/hurannsisukozabieru"); name.GetComponent<Text>().text = "フランシスコ・ザビエル"; description.GetComponent<Text>().text = "・日本にキリスト教布教\n・カトリック教会\n・聖人"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/gannzi-"); name.GetComponent<Text>().text = "ガンジー"; description.GetComponent<Text>().text = "・インド\n・独立運動\n・非暴力不服従"; }
                break;
            case 10:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/zyannnudaruku"); name.GetComponent<Text>().text = "ジャンヌ・ダルク"; description.GetComponent<Text>().text = "・フランス\n・百年戦争\n・オルレアン\n・聖女"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/seisyounagonn"); name.GetComponent<Text>().text = "清少納言"; description.GetComponent<Text>().text = "・本名は「清原諾子」\n・平安時代\n・枕草子"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/naitinnge-ru"); name.GetComponent<Text>().text = "ナイチンゲール"; description.GetComponent<Text>().text = "・看護婦\n・イギリス\n・クリミアの天使"; }
                break;
            case 11:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/aketimituhide"); name.GetComponent<Text>().text = "明智光秀"; description.GetComponent<Text>().text = "・謀反\n・本能寺の変\n・敵は本能寺にあり"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/inoutatdataka"); name.GetComponent<Text>().text = "伊能忠敬"; description.GetComponent<Text>().text = "・測量\n・日本地図"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/sibusawaeiiti"); name.GetComponent<Text>().text = "渋沢栄一"; description.GetComponent<Text>().text = "・新一万円札\n・商法会所\n・資本主義の父"; }
                break;
            case 12:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/davinnti"); name.GetComponent<Text>().text = "レオナルド・ダ・ヴィンチ"; description.GetComponent<Text>().text = "・画家\n・天才\n・モナリザ\n・最後の晩餐"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/mikerannzyaro"); name.GetComponent<Text>().text = "ミケランジェロ"; description.GetComponent<Text>().text = "・芸術家\n・彫刻\n・ダビデ像\n・最後の審判"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/ainnsyutainn"); name.GetComponent<Text>().text = "アインシュタイン"; description.GetComponent<Text>().text = "・物理学者\n・舌\n・特殊相対性理論"; }
                break;
            case 13:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/tinngisuhann"); name.GetComponent<Text>().text = "チンギス・ハン"; description.GetComponent<Text>().text = "・モンゴル\n・征服者\n・英雄"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/koronnbusu"); name.GetComponent<Text>().text = "コロンブス"; description.GetComponent<Text>().text = "・航海者\n・探検家\n・卵\n・コンキスタドール\n・奴隷商人"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/sikoutei"); name.GetComponent<Text>().text = "始皇帝"; description.GetComponent<Text>().text = "・中国統一\n・焚書\n・水銀"; }
                break;
            case 14:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/peri-"); name.GetComponent<Text>().text = "ペリー"; description.GetComponent<Text>().text = "・外国人\n・海軍\n・黒船\n・開国"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/rinnka-"); name.GetComponent<Text>().text = "リンカーン"; description.GetComponent<Text>().text = "・アメリカ\n・大統領\n・奴隷解放宣言\n・人民の,人民による,人民のための政治"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/no-beru"); name.GetComponent<Text>().text = "ノーベル"; description.GetComponent<Text>().text = "・化学者\n・ダイナマイト\n・世界的な賞"; }
                break;
            case 15:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/takirenntarou"); name.GetComponent<Text>().text = "滝廉太郎"; description.GetComponent<Text>().text = "・日本\n・音楽家\n・花\n・荒城の月\n・憾"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/syaikusupia"); name.GetComponent<Text>().text = "シェイクスピア"; description.GetComponent<Text>().text = "・イングランド\n・劇作家\n・ハムレット\n・ロミオとジュリエット"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/anntonio"); name.GetComponent<Text>().text = "アントニオ"; description.GetComponent<Text>().text = "・イタリア\n・音楽家\n・風評被害"; }
                break;
            case 16:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/greatman/kaesaru"); name.GetComponent<Text>().text = "カエサル"; description.GetComponent<Text>().text = "・ローマ\n・婚約者はクレオパトラ\n・賽は投げられた\n・来た、見た、勝った\n・ブルータス、お前もか"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/greatman/puratonn"); name.GetComponent<Text>().text = "プラトン"; description.GetComponent<Text>().text = "・ギリシャ\n・哲学者\n・ソクラテスの弟子\n・イデア"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/greatman/minamotonoyositune"); name.GetComponent<Text>().text = "源義経"; description.GetComponent<Text>().text = "・源氏\n・幼名は牛若丸\n・八艘飛び"; }
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
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/burokkori-"); name.GetComponent<Text>().text = "ブロッコリー"; description.GetComponent<Text>().text = "・緑\n・もじゃもじゃ\n・緑黄色野菜"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/pi-mnn"); name.GetComponent<Text>().text = "ピーマン"; description.GetComponent<Text>().text = "・緑\n・苦い\n・緑黄色野菜\n・炒め物によく使う"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/kyuuri"); name.GetComponent<Text>().text = "きゅうり"; description.GetComponent<Text>().text = "・緑\n・苦い\n・みずみずしい"; }
                break;
            case 1:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/kyabetu"); name.GetComponent<Text>().text = "キャベツ"; description.GetComponent<Text>().text = "・葉\n・玉\n・肉を巻く\n・千切り"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/retasu"); name.GetComponent<Text>().text = "レタス"; description.GetComponent<Text>().text = "・葉\n・挟むことが多い\n・サラダ"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/hakusai"); name.GetComponent<Text>().text = "白菜"; description.GetComponent<Text>().text = "・緑と白\n・冬・鍋によく使う"; }
                break;
            case 2:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/tomato"); name.GetComponent<Text>().text = "トマト"; description.GetComponent<Text>().text = "・赤\n・酸っぱい\n・リコピン\n・回文"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/jagaimo"); name.GetComponent<Text>().text = "ジャガイモ"; description.GetComponent<Text>().text = "・デンプン\n・芽に毒\n・根ではなく茎です"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/papurika"); name.GetComponent<Text>().text = "パプリカ"; description.GetComponent<Text>().text = "・赤\n・黄\n・サラダ\n・実はイチゴより甘い"; }
                break;
            case 3:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/komatuna"); name.GetComponent<Text>().text = "小松菜"; description.GetComponent<Text>().text = "・葉\n・雑煮\n・おひたし"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/serori"); name.GetComponent<Text>().text = "セロリ"; description.GetComponent<Text>().text = "・葉\n・匂いが強い\n・臭み消しに使われる"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/karihurawa-"); name.GetComponent<Text>().text = "カリフラワー"; description.GetComponent<Text>().text = "・白\n・もじゃもじゃ\n・アルビノ"; }
                break;
            case 4:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/tora"); name.GetComponent<Text>().text = "トラ"; description.GetComponent<Text>().text = "・天敵がいない\n・ガオー\n・シマシマ模様"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/raionn"); name.GetComponent<Text>().text = "ライオン"; description.GetComponent<Text>().text = "・百獣の王\n・ガオー\n・たてがみ"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/ti-ta-"); name.GetComponent<Text>().text = "チーター"; description.GetComponent<Text>().text = "・速い\n・ガオー\n・黒い水玉模様"; }
                break;
            case 5:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/usi"); name.GetComponent<Text>().text = "牛"; description.GetComponent<Text>().text = "・牛乳\n・もーもー\n・白と黒の班目模様"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/niwatori"); name.GetComponent<Text>().text = "にわとり"; description.GetComponent<Text>().text = "・タマゴ\n・こけこっこー！\n・赤いトサカがかっこいい"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/buta"); name.GetComponent<Text>().text = "豚"; description.GetComponent<Text>().text = "・豚肉\n・ぶーぶー\n・実は俊足"; }
                break;
            case 6:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/kitune"); name.GetComponent<Text>().text = "狐"; description.GetComponent<Text>().text = "・ライバルはタヌキ\n・こーん\n・油揚げ"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/tanuki"); name.GetComponent<Text>().text = "狸"; description.GetComponent<Text>().text = "・ライバルはキツネ\n・ぽんぽん\n・天かす"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/nezumi"); name.GetComponent<Text>().text = "ネズミ"; description.GetComponent<Text>().text = "・干支の初め\n・ちゅーちゅー\n・チーズ"; }
                break;
            case 7:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/kuruma"); name.GetComponent<Text>().text = "車"; description.GetComponent<Text>().text = "・・1~5人用\n・速い\n・道路を走る"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/zitennsya"); name.GetComponent<Text>().text = "自転車"; description.GetComponent<Text>().text = "・一人用\n・遅い\n・道路を走る"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/basu"); name.GetComponent<Text>().text = "バス"; description.GetComponent<Text>().text = "・一度に多くの人を運ぶ\n・縦に長い\n・道路を走る"; }
                break;
            case 8:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/hikouki"); name.GetComponent<Text>().text = "飛行機"; description.GetComponent<Text>().text = "・一度に多くの人を運ぶ\n・長い距離を移動\n・空を飛ぶ・ジェットエンジンで飛行"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/dennsya"); name.GetComponent<Text>().text = "電車"; description.GetComponent<Text>().text = "・一度に多くの人を運ぶ\n・長い距離を移動\n・線路に乗って移動"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/hune"); name.GetComponent<Text>().text = "船"; description.GetComponent<Text>().text = "・一度に多くの人を運ぶ\n・浮いている\n・海を走る"; }
                break;
            case 9:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/f1"); name.GetComponent<Text>().text = "F1"; description.GetComponent<Text>().text = "・１人用\n・レース\n・Gがかかる\n・超早い"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/bagi-"); name.GetComponent<Text>().text = "バギー"; description.GetComponent<Text>().text = "・１～２用\n・車体は小さい\n・オフロード走行に特化"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/baiku"); name.GetComponent<Text>().text = "バイク"; description.GetComponent<Text>().text = "・１～２用\n・小回りが利く\n・道都を走る"; }
                break;
            case 10:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/ro-doro-ra-"); name.GetComponent<Text>().text = "ロードローラー"; description.GetComponent<Text>().text = "・工事用車両\n・アスファルト\n・鈍足"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/syoberuka-"); name.GetComponent<Text>().text = "ショベルカー"; description.GetComponent<Text>().text = "・工事用車両\n・アーム\n・掘削"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/burudo-za-"); name.GetComponent<Text>().text = "ブルドーザー"; description.GetComponent<Text>().text = "・工事用車両\n・整地\n・キャタピラ"; }
                break;
            case 11:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/maguro"); name.GetComponent<Text>().text = "マグロ"; description.GetComponent<Text>().text = "・赤身\n・トロ\n・止まらない"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/sake"); name.GetComponent<Text>().text = "鮭"; description.GetComponent<Text>().text = "・実は白身魚\n・母川回帰\n・イクラ"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/iwasi"); name.GetComponent<Text>().text = "イワシ"; description.GetComponent<Text>().text = "・海水魚\n・群れで行動する\n・アンチョビ\n・稚魚はシラス"; }
                break;
            case 12:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/same"); name.GetComponent<Text>().text = "サメ"; description.GetComponent<Text>().text = "・大きい\n・凶暴\n・牙\n・フカヒレ"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/si-rakannsu"); name.GetComponent<Text>().text = "シーラカンス"; description.GetComponent<Text>().text = "・深海魚\n・古代魚\n・生きた化石"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/hugu"); name.GetComponent<Text>().text = "ふぐ"; description.GetComponent<Text>().text = "・丸\n・卵巣や肝臓に毒\n・糠漬けにすると何故か毒が消える"; }
                break;
            case 13:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/kabutomusi"); name.GetComponent<Text>().text = "カブトムシ"; description.GetComponent<Text>().text = "・甲虫\n・オスは角がある\n・虫相撲"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/kuwagatamusi"); name.GetComponent<Text>().text = "クワガタムシ"; description.GetComponent<Text>().text = "・甲虫\n・一対の顎を持つ\n・雑木林などにいる"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/cyou"); name.GetComponent<Text>().text = "蝶"; description.GetComponent<Text>().text = "・飛ぶ\n・完全変態\n・蜜を吸う"; }
                break;
            case 14:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/hati"); name.GetComponent<Text>().text = "蜂"; description.GetComponent<Text>().text = "・黄色と黒\n・毒針を持つ\n・ハニカム構造の巣\n・蜜を集める種類もいる"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/semi"); name.GetComponent<Text>().text = "セミ"; description.GetComponent<Text>().text = "・飛ぶ\n・実は寿命は７日ではない\n・樹液を吸う\n・うるさい"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/ari"); name.GetComponent<Text>().text = "アリ"; description.GetComponent<Text>().text = "・社会性昆虫\n・黒\n・小さい"; }
                break;
            case 15:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/yakyuu"); name.GetComponent<Text>().text = "野球"; description.GetComponent<Text>().text = "・バット\n・ボール\n・グローブ"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/sakka-"); name.GetComponent<Text>().text = "サッカー"; description.GetComponent<Text>().text = "・手を使わない\n・ボール\n・ドリブル"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/kenndou"); name.GetComponent<Text>().text = "剣道"; description.GetComponent<Text>().text = "・竹刀\n・防具\n・掛け声"; }
                break;
            case 16:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/bare-"); name.GetComponent<Text>().text = "バレー"; description.GetComponent<Text>().text = "・一瞬しか触れられない\n・ボール\n・背が高いと有利"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/basuke"); name.GetComponent<Text>().text = "バスケ"; description.GetComponent<Text>().text = "・ドリブル\n・ボール\n・背が高いと有利"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/ragubi-"); name.GetComponent<Text>().text = "ラグビー"; description.GetComponent<Text>().text = "・変わったボール\n・手足両方使う\n・トライ"; }
                break;
            case 17:
                if (v.answer == 0) { img.sprite = Resources.Load<Sprite>("images/chaos/takkyuu"); name.GetComponent<Text>().text = "卓球"; description.GetComponent<Text>().text = "・ラケット\n・ボール\n・ラバー"; }
                if (v.answer == 1) { img.sprite = Resources.Load<Sprite>("images/chaos/tenisu"); name.GetComponent<Text>().text = "テニス"; description.GetComponent<Text>().text = "・ラケット\n・ボール\n・ガット"; }
                if (v.answer == 2) { img.sprite = Resources.Load<Sprite>("images/chaos/batominntonn"); name.GetComponent<Text>().text = "バトミントン"; description.GetComponent<Text>().text = "・ラケット\n・シャトル\n・スピードが特殊"; }
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
}
