using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusHandler : MonoBehaviour
{
    [SerializeField] private Status baseStat;
    public Status CurrentStatus { get; private set; }

    private void Awake()
    {
        UpdateCharacterStatus();
    }

 
    private void UpdateCharacterStatus()
    {
        CurrentStatus = new Status();
        CurrentStatus.maxHP = baseStat.maxHP;
        CurrentStatus.ATK = baseStat.ATK;
        CurrentStatus.DEF = baseStat.DEF;
        CurrentStatus.CRI = baseStat.CRI;
        CurrentStatus.EXP = baseStat.EXP;
        CurrentStatus.LV = Lv();
        CurrentStatus.GOLD = baseStat.GOLD;
    }

    public int Lv()
    {
        int setLv=baseStat.EXP / 10;
        if(setLv==0) { setLv = 1; }
        return setLv;
    }
}
