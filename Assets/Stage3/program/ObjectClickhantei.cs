using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86;
using static UnityEngine.ParticleSystem;

public class ObjectClickhantei : MonoBehaviour
{
    public GManegeryasai GManegeryasai;
    public AudioSource audioSource;
    public AudioClip se2;
    private string namae;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if (GManegeryasai.kosuu < 3)
        {
            this.gameObject.SetActive(false);
            GManegeryasai.first[i] = this.gameObject.tag;
            i = i + 1;
            Debug.Log(GManegeryasai.kosuu);
            Debug.Log(GManegeryasai.first[i]);
            GManegeryasai.kosuu =   GManegeryasai.kosuu + 1;
        }
    }

}
