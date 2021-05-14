using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public Text[] buttonList;

    void Awake () 
    {
        SetGameControllerReferenceOnButtons();
    }
    
    void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {            
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }
    
    public string GetPlayerSide () 
    {
        return "?";
    }
    
    public void EndTurn () 
    { 
        Debug.Log("EndTurn is not implemented!"); 
    }
}