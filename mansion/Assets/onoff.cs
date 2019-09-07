using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour
{

    public Material[] _material;           // 割り当てるマテリアル.
    private int i;
    [SerializeField] public string lightname ;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        cube = GameObject.Find(lightname);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
     
                i++;
                if (i == 3)
                {
                    i = 0;
                
                  }

                this.GetComponent<Renderer>().material = _material[i];
            cube.SetActive((i % 2 == 0) ? true : false);

        }
        

    }
}
