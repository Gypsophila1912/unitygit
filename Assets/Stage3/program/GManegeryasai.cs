using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class GManegeryasai : MonoBehaviour
{
    [SerializeField] GameObject erabe;
    public TimeCountScript timeCountScript;
    public yasaiseisei yasaiseisei;
    public int kosuu = 0;
    public static  string[] first;
    // Start is called before the first frame update
    void Start()
    {
        erabe.SetActive(true);
        StartCoroutine("kaisi");
        for (int i = 0; i < yasaiseisei.btn.Length; i++)
        {
            yasaiseisei.btn[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator kaisi()
    {
        yield return new WaitForSeconds(1);
        erabe.SetActive(false);
        timeCountScript.kaisijyouken = true;
        yasaiseisei.Seisei();
    }
}
