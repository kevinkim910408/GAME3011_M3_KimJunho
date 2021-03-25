using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySetting : MonoBehaviour
{
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
                break;
            case 1:
                Debug.Log("NORMAL");
                difficulties = Difficulties.NORMAL;
                break;
            case 2:
                Debug.Log("HARD");
                difficulties = Difficulties.HARD;
                break;
        }
    }
}
