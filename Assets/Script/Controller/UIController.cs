using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    GameObject popup = null;
    public void ShowUIONOFF(GameObject obj)
    {
        if(popup == null)
        {
            popup = Instantiate(obj);
            popup.SetActive(true);
        }
        else
        {
            Destroy(popup);
        }

    } 
}
