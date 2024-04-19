using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSender : MonoBehaviour
{
    CustomSetVariable trialNum;
    int count = 0;
    void Start()
    {
        var bci2000 = GetComponent<UnityBCI2000>();
       trialNum = new CustomSetVariable(bci2000, "trialNum");
    }

    // Update is called once per frame
    void Update()
    {
        trialNum.Update(count++);
    }
}


class CustomSetVariable
{
    UnityBCI2000 bci2000;
    string keyName;
    public CustomSetVariable(UnityBCI2000 bci2000, string keyName)
    {
        bci2000.AddState(keyName);
        this.keyName = keyName;
        this.bci2000 = bci2000;
    }
    public void Update(int newValue)
    {
        if (newValue != value)
        {
            bci2000.SetState(keyName, newValue);
            value = newValue;
        }
    }
    public int value { get; private set; } = -1;
}