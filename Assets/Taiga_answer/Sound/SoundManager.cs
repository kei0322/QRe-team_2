using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //必要です！！

public class SoundManager : MonoBehaviour
{
    //ヒエラルキーからD&Dしておく
    public AudioClip BGM_lobby;
    public AudioClip BGM_game;

    public GameObject fadepanel;
    //使用するAudioSource
    private AudioSource source;

    //１つ前のシーン名
    private string beforeScene = "Launcher";

    // Use this for initialization
    void Start()
    {
        //自分をシーン切り替え時も破棄しないようにする
        DontDestroyOnLoad(gameObject);

        //使用するAudioSource取得
        source = GetComponent<AudioSource>();

        //最初のBGM再生
        source.clip = BGM_lobby;
        Invoke("SoundPlay", 3.5f);//白いパネルの表示時間＋0.5fくらいがちょうどよさそう
       

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    //シーンが切り替わった時に呼ばれるメソッド
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        //シーンがどう変わったかで判定

        //ロビーからゲームへ
        if (beforeScene == "Lobby" && nextScene.name == "New_Questions")
        {
            source.Stop();
            source.clip = BGM_game;    //流すクリップを切り替える
            source.Play();
        }

        //ゲームからロビーへ
        if (beforeScene == "New_Questions" && nextScene.name == "Lobby")
        {
            source.Stop();
            source.clip = BGM_lobby;    //流すクリップを切り替える
            source.Play();
        }

        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }

    void SoundPlay()
    {
        source.Play();
        fadepanel.gameObject.SetActive(false);
    }
}
