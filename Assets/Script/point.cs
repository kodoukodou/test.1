using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class point : MonoBehaviour
{
    int Point = 0;
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Point:" + Point.ToString();
    }

    public void AddPoint()
    {
        Point++;
    }
}
