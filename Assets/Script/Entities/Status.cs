using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[Serializable]
public class Status
{
    [Range(1, 100)] public int maxHP;
    [Range(1, 100)] public int ATK;
    [Range(1, 100)] public int DEF;
    [Range(1, 100)] public int CRI;

    public string Name = "KIM";
    public string jop = "Wizard";
    public int EXP = 0;
    public int LV = 1;
    public int GOLD = 1000;
}
