using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nullable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

/*         {
            int? a = null;

            Debug.Log(a.HasValue);
            Debug.Log(a != null);

            a = 3;

            Debug.Log(a.HasValue);
            Debug.Log(a != null);
            Debug.Log(a.Value);
        } */

        
            var a = 20;
            Debug.Log($"Type: {a.GetType()}, value: {a}");
            var b = 3.1414213;
            Debug.Log($"Type: {b.GetType()}, value: {b}");
            var c = "Hello, world";
            Debug.Log($"Type: {c.GetType()}, value: {c}");
            var d = new int[]{10,20,30};
            foreach (var e in d){
                Debug.Log(e);
            

        }

    }


}
