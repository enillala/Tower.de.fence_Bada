using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delagateexample : MonoBehaviour
{
    public delegate void SimpleDelegate();

    SimpleDelegate exampleDelegate;

    private void Start()
    {
        exampleDelegate = HelloWorld;
        exampleDelegate();

        exampleDelegate += GoodbyeWorld;
        exampleDelegate();
    }
    void HelloWorld()
    {
        Debug.Log("Hello world");
    }
    void GoodbyeWorld()
    {
        Debug.Log(" Farewell, world");
    }
}
