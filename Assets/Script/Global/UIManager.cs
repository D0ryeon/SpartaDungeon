using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI jop;
    public TextMeshProUGUI name;
    public TextMeshProUGUI lv;

    public TextMeshProUGUI exp;
    public GameObject expView;

    public TextMeshProUGUI gold;

    // Start is called before the first frame update
    void Start()
    {
        StatusHandler test = player.GetComponent<StatusHandler>();
        UIstatusSet(test);
    }

    private void UIstatusSet(StatusHandler test)
    {
        
        jop.text = test.CurrentStatus.jop.ToString();
        name.text = test.CurrentStatus.Name.ToString();
        lv.text = test.CurrentStatus.LV.ToString();
        exp.text = (test.CurrentStatus.EXP % 10).
            ToString() + " / 10";
        gold.text = GoldFormat(test.CurrentStatus.GOLD);
        expView.GetComponent<RectTransform>().sizeDelta = new Vector2(222 / 10 * (test.CurrentStatus.EXP % 10), 0);

        // Update is called once per frame
        void Update()
        {

        }

        
    }
    public string GoldFormat(int gold)
    {
        return string.Format("{0:#,###}", gold);
    }
}
