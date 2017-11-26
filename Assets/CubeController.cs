using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadline = -10;

    // 地面の位置(課題１)
    //private float groundLevel = -3.0f; //(課題１)
    //地面に当たる判定
    //private bool isEnd = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }

        // キューブが地面に接触していない時とキューブ同士が積み重なっていないときにはボリュームを0にする（課題１）
        //GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;

    }
    //１．キューブが地面に接触する時とキューブ同士が積み重なるときに効果音をつけてください（課題１）
    void OnCollisionEnter2D(Collision2D other) //注意２．←Collider2Dとしていた。スペルに気を付ける　
                                               //注意３．Loop、Play On Awakeのチェックを外す
    {
        //キューブが地面に接触する時
        if (other.gameObject.tag == "GroundTag")
        {
            //Debug.Log("ここは通った");
            GetComponent<AudioSource>().Play();
            //this.isEnd = true;
        }
        //注意１．↑このスクリプトだと一定間隔でblockの音源がなるだけ←上注意２．、３．で解決

        //キューブ同士が積み重なるとき
        if (this.gameObject.tag == "CubePrefabTag")
        {
            GetComponent<AudioSource>().Play();
        }
      
    }
}
