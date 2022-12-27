using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    public Text MyText;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "Collect 10 mushrooms by clicking on them";       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(int score)
    {
        if (score < 1)
        {
            MyText.text = "Collect 10 mushrooms by clicking on them";       
        }
        else if (score > 10)
        {
        }
        else
        {
            MyText.text = string.Format("Collected: {0} \n{1} Left", score, 10-score);
        }
    }
}
