using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class suraida : MonoBehaviour
{
    [SerializeField] Slider slider;
    private bool Max;
    private bool min;
    private bool Click;
    private float byousuu = 0.04f;
    private GameObject futuu;
    private GameObject seikou;
    private int ninn;//もらった人数
    private int yasai;//もらった野菜の数
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        Max = false;
        Click = false;
        //もらった人数をninnとする
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Click = true;
            SceneManager.LoadScene("Stage3/Stage3_kekka");//結果画面へ行く
        }

        if(Click == false)
        {
            if (slider.value == 10)
            {
                Max = true;
            }
            else if (slider.value == 0)
            {
                Max = false;
            }

            if(Max == false)
            {
                slider.value += byousuu;
            }
            else if(Max == true) 
            {
                slider.value -= byousuu;
            }
        }



    }
    //スライダーの範囲を変更させる。スピードを変更は時間的に間に合わない可能性がある
}
