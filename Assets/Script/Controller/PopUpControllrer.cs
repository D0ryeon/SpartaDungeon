using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;

public class PopUpControllrer : MonoBehaviour
{

    public TextMeshProUGUI ATK;
    public TextMeshProUGUI DEF;
    public TextMeshProUGUI HP ;
    public TextMeshProUGUI CRI;
    public List<string> inventory;
    public GameObject myself;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player"); 
 
    }

    private void Start()
    {
        StatusHandler test = player.GetComponent<StatusHandler>();
        Debug.Log(test.CurrentStatus);
        Status stat = test.CurrentStatus;
        Debug.Log("test" + stat);
        SetStatus(stat);
    }

    private void SetStatus(Status stat)
    {
        ATK.text = "1";
        DEF.text = stat.DEF.ToString();
        HP.text = stat.maxHP.ToString();
        CRI.text = stat.CRI.ToString();
    }
    public void ClosePopup()
    {
        Destroy(myself);
    }
}
