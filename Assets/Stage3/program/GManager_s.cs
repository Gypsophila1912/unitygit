using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GManager_s : MonoBehaviour
{
    [SerializeField] GameObject tomero;
    public GameObject[] Marker = new GameObject[3];
    public GameObject[] seikouobj;//ninnzuuuniyottehyoujisuuwokaeru
    public bool[] seikou = {false};//hyoujisitearutokoroha true nisiteoku
    public TimeCountScript timeCountScript;
    public static GManager_s instance = null;
    [SerializeField] Slider slider;
    public int totalScore;
    public int stageIndex = -1;  //ランダムセレクト時のステージ番号, StageRandomSelectで使用
    public static int kekka;
    private int[] first;
    

    private void Start()
    {
        tomero.SetActive(true);

        StartCoroutine("hajime");
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }


    }

    IEnumerator hajime()
    {
        yield return new WaitForSeconds(1);
        tomero.SetActive(false);
        timeCountScript.count = 10;
        timeCountScript.kaisijyouken = true;
    }

    private void kekkasyori()//最初にタグによって数字に変換する
    {
        for (int i = 0; i < 3; i++)
        {
            if(GManegeryasai.first[i] == "hokori")
            {
                first[i] = 0;
            }
            else if(GManegeryasai.first[i] == "kann")
            {
                first[i] = 0;
            }
            else if (GManegeryasai.first[i] == "jyaga")
            {
                first[i] = 1;
            }
            else if (GManegeryasai.first[i] == "ninn")
            {
                first[i] = 2;
            }
            else if (GManegeryasai.first[i] == "niku")
            {
                first[i] = 3;
            }

        }


        if ((slider.value <= 3.1 && slider.value >= 3.7) || (slider.value <= 4.8 && slider.value <= 5.3) || (slider.value <= 6.3 && slider.value <= 6.9))
        {
            if (first[1] == 1)
            {
                if(first[2] == 1)
                {
                    if (first[3] == 1)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 2;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 0;
                    }
                }
                else if (first[2] == 2)
                {
                    if (first[3] == 1)
                    {
                        kekka = 2;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 1;
                    }
                }
                else if (first[2] == 3)
                {
                    if (first[3] == 1)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 1;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 0;
                    }
                }
            }
            else if(first[1] == 2)
            {
                if (first[2] == 1)
                {
                    if (first[3] == 1)
                    {
                        kekka = 2;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 1;
                    }
                }
                else if (first[2] == 2)
                {
                    if (first[3] == 1)
                    {
                        kekka = 1;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 0;
                    }
                }
                else if (first[2] == 3)
                {
                    if (first[3] == 1)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 1;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 0;
                    }
                }
            }
            else if (first[1] == 3)
            {
                if (first[2] == 1)
                {
                    if (first[3] == 1)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 1;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 0;
                    }
                }
                else if (first[2] == 2)
                {
                    if (first[3] == 1)
                    {
                        kekka = 1;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 0;
                    }
                }
                else if (first[2] == 3)
                {
                    if (first[3] == 1)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 2)
                    {
                        kekka = 0;
                    }
                    else if (first[3] == 3)
                    {
                        kekka = 3;
                    }
                }
            }
            else if(first[1] == 0)
            {
                kekka = 0;
            }
        }
        else
        {
            kekka = 0;
        }
    }
}