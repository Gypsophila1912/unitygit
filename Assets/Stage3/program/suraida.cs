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
    private int ninn;//��������l��
    private int yasai;//���������؂̐�
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        Max = false;
        Click = false;
        //��������l����ninn�Ƃ���
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Click = true;
            SceneManager.LoadScene("Stage3/Stage3_kekka");//���ʉ�ʂ֍s��
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
    //�X���C�_�[�͈̔͂�ύX������B�X�s�[�h��ύX�͎��ԓI�ɊԂɍ���Ȃ��\��������
}
