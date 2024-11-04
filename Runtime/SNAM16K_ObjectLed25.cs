using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Eloi.SNAM;
public class SNAM16K_ObjectLed25 : SNAM_Generic16KMono<STRUCT_Led25PercentLRDT> {


    public int m_lastIndexReceived;
    public int m_lastValueReceived;
    public void PushIn(int index, int value)
    {
        m_lastIndexReceived = index;
        m_lastValueReceived = value;
        STRUCT_Led25PercentLRDT led = Get(index);
        Led25GridUtility.SetLedWithInteger25BitsRightToLeft(out led, value);
        Set(index, led);
    } 
}
