using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCountScript_s : MonoBehaviour
{
    public float count = 5;
    public int jyouken = 0;
    Text scoreText;
    public bool kaisijyouken = false;
    //[SerializeField] string loadSceneName = "StageSelectScene";
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {//条件変更と同時に時間更新しておく
        if (kaisijyouken == true)
        {
            count -= Time.deltaTime;
            scoreText.text = (int)count + "";//スコアの表示ができる（スコアテキストにインスペクターでつけておく）

            if (count <= 0)
            {
                kaisijyouken = false;
                if (jyouken == 0)
                {
                    jyouken = 1;
                    SceneManager.LoadScene("Stage3/Stage3_tomeru");
                }
                else if (jyouken == 1)
                {
                    SceneManager.LoadScene("Stage3/Stage3_tomeru");
                }
            }
        }
    }
}
