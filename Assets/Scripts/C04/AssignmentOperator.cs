using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;

        a = 100;
        Debug.Log($"a = 100 : {a} ");
        a += 90;
        Debug.Log($"a += 90 : {a} ");
        a -= 80;
        Debug.Log($"a -= 100 : {a} ");
        a *= 70;
        Debug.Log($"a = 100 : {a} ");
        a /= 60;
        Debug.Log($"a = 100 : {a} ");
        a %= 50;
        Debug.Log($"a = 100 : {a} ");
        a %= 40;
        Debug.Log($"a = 100 : {a} ");
        a |= 30;
        Debug.Log($"a = 100 : {a} ");
        a ^= 20;
        Debug.Log($"a = 100 : {a} ");
    }


}
