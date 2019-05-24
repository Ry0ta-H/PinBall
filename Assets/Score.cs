using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //スコアを表示する
    public GameObject scoreText;

    //スコアを表するテキスト
    private int score = 0;

    // Use this for initialization

    void Start() {
        this.scoreText = GameObject.Find("scoreText");
        score = 0;

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        string tag = other.gameObject.tag;
        if (tag == "LargeCloudTag")
        {
            score += 100;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeStarTag")
        {
            score += 50;
        }
        else if (tag == "SmallStarTag" )
        {
            score += 1;
        }
        Debug.Log(score);
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}
