using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //（追加）

public class UIController : MonoBehaviour {

    // ゲームオーバテキスト
    public GameObject gameOverText;

    // 走行距離テキスト
    private GameObject runLengthText;

    // 走った距離
    private float len = 0;

    // 走る速度
    private float speed = 0.03f;

    // ゲームオーバの判定
    public bool isGameOver = false;

    // Use this for initialization
    void Start () {
        // シーンビューからオブジェクトの実体を検索する
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");

    }

    // Update is called once per frame
    void Update() {
        if (this.isGameOver == false)
            // 走った距離を更新する
            this.len += this.speed;

        // 走った距離を表示する
        this.runLengthText.GetComponent<Text>().text = len.ToString("F2")/*このF2って何？:引数を"F2"とすることで、小数部を2桁まで表示するように書式指定しています。*/ + "m";

        // ゲームオーバになった場合
        if (this.isGameOver)
        {
        // クリックされたらシーンをロードする（追加）

        }

    }
    void GameOver()
    {
        // ゲームオーバになったときに、画面上にゲームオーバを表示する
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
