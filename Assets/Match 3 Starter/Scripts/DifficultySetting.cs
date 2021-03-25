using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySetting : MonoBehaviour
{
    // Difficulty Text
    [SerializeField] Text diffText = null; 
    [SerializeField] Text InstructorText = null; 

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
                InstructorText.text = "Difficulty\n\"EASY\"\nNeed to Match\n3 Straight\nTiles";
                break;
            case 1:
                Debug.Log("NORMAL");
                difficulties = Difficulties.NORMAL;
                InstructorText.text = "Difficulty\n\"NORMAL\"\nNeed to Match\n4 Straight\nTiles";
                diffText.text = "NORMAL";
                break;
            case 2:
                Debug.Log("HARD");
                difficulties = Difficulties.HARD;
                InstructorText.text = "Difficulty\n\"HARD\"\nNeed to Match\n5 Straight\nTiles";
                diffText.text = "HARD";
                break;
        }
    }
}
