using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySetting : MonoBehaviour
{
    // Difficulty Text
    [SerializeField] Text diffText = null; 

    // enum for setting difficulties
    public enum Difficulties
    {
        EASY,
        NORMAL,
        HARD,
    }

    // a variable that contain difficulty 
    public Difficulties difficulties;

    // used at Dropdown
    public void SetDifficulty(int value)
    {
        switch (value)
        {
            case 0:
                Debug.Log("EZ");
                difficulties = Difficulties.EASY;
                diffText.text = "EASY";
                break;
            case 1:
                Debug.Log("NORMAL");
                difficulties = Difficulties.NORMAL;
                diffText.text = "NORMAL";
                break;
            case 2:
                Debug.Log("HARD");
                difficulties = Difficulties.HARD;
                diffText.text = "HARD";
                break;
        }
    }
}
