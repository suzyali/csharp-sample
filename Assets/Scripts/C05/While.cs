using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = new int[] { 0, 1, 2, 3, 4 };

        foreach (int a in arr)  //arr: ������ ���� �� �ִ�
        { 
            Debug.Log(a);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
