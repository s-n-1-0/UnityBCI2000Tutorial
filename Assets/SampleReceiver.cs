using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleReceiver : MonoBehaviour
{
    UnityBCI2000 bci2000;
    void Start()
    {
        bci2000 = GetComponent<UnityBCI2000>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bci2000.GetState("predictClass"));
    }
}
