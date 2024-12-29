using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class yasaiseisei : MonoBehaviour
{
    public GameObject[] syokuzai;//何個分の食材を使えるかだと数をもらうだけ。どの食材を使うか（食材の種類）を渡されると、フラグ立てのやつがやりやすいかも
    public Sprite[] syokuzai_s;
    public GameObject[] btn;
    int soeji;

    private Image image;
    private Sprite sprite;
    // Start is called before the first frame update
    public void Seisei()
    {
        for (int i = 0; i < 13; i++)
        {
            image = btn[i].GetComponent<Image>();
            soeji = Random.Range(0, syokuzai_s.Length);
            sprite = syokuzai_s[soeji];
            image.sprite = sprite;
            if(soeji == 0)
            {
                btn[i].tag = "hokori";
            }
            else if(soeji == 1)
            {
                btn[i].tag = "kann";
            }
            else if (soeji == 2)
            {
                btn[i].tag = "jyaga";
            }
            else if (soeji == 3)
            {
                btn[i].tag = "ninn";
            }
            else if (soeji == 4)
            {
                btn[i].tag = "niku";

            }
            btn[i].SetActive(true);
        }
    }

}
