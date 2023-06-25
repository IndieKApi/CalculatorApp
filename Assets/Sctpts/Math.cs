using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Math : MonoBehaviour
{
    public InputField display;

    public int previous=0, current=0, function = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Store(int value)
    {
        if (display.text != "")
        {
            if (display.text == "+")
            {
                display.text = value.ToString();
                current = value;
            }
            else if (display.text == "-")
            {
                display.text = value.ToString();
                current = value;
            }
            else if (display.text == "X")
            {
                display.text = value.ToString();
                current = value;
            }
            else if (display.text == "/")
            {
                display.text = value.ToString();
                current = value;
            }
            else
            {
                display.text = display.text + value;
                current = int.Parse(display.text);
            }
        }
        else
        {
            display.text = value.ToString();
            current = value;
        }
    }
    public void Sum()
    {
        previous =int.Parse( display.text);
        display.text = "+";
        function = 1;

    }
    public void Sub()
    {
        previous = int.Parse(display.text);
        display.text = "-";
        function = 2;
    }
    public void Mul()
    {
        previous = int.Parse(display.text);
        display.text = "X";
        function = 3;
    }
    public void Div()
    {
        previous = int.Parse(display.text);
        display.text = "/";
        function = 4;
    }
    public void Clear()
    {
        display.text = "";
        previous = 0;
        current = 0;
        function = 0;
    }
    public void Cal()
    {
        if (function == 1)
        {
            display.text = (previous + current).ToString();
            
        }
        if (function == 2)
        {
            display.text = (previous - current).ToString();

        }
        if (function == 3)
        {
            display.text = (previous * current).ToString();

        }
        if (function == 4)
        {
            display.text = (previous / current).ToString();

        }
    }

}
