using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        int j = 1;

        bool b1 = true;
        bool b2 = false;

        if (b1 || b2)
        {

            Debug.Log("i°¡ jº¸´Ù Å­!");
        }



        string result = (10 % 2) == 0 ? "Â¦¼ö" : "È¦¼ö";

        Debug.Log(result);

        

    }


}
