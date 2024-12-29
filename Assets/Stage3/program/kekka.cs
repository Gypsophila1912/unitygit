using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kekka : MonoBehaviour
{
    private GameObject hyouji;
    public GameObject[] ryouri;
    public GameObject Firstmarker;

    // Start is called before the first frame update
    void Start()
    {
        if(GManager_s.kekka == 0)
        {
            hyouji = Instantiate(ryouri[0]);
            hyouji.transform.position = Firstmarker.transform.position;
        }
        else if(GManager_s.kekka == 1)
        {
            hyouji = Instantiate(ryouri[1]);
            hyouji.transform.position = Firstmarker.transform.position;
        }
        else if (GManager_s.kekka == 2)
        {
            hyouji = Instantiate(ryouri[2]);
            hyouji.transform.position = Firstmarker.transform.position;
        }
        else if (GManager_s.kekka == 3)
        {
            hyouji = Instantiate(ryouri[3]);
            hyouji.transform.position = Firstmarker.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
