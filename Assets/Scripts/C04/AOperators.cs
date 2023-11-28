using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOperators : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        string result = "123" + "456";
        Debug.Log(result);

        result = "Hello" + " " + "World";
        Debug.Log(result);

   
    }


}
