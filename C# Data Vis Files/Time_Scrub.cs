using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.


public class Time_Scrub : MonoBehaviour
{
    //access datavisualizer GameObject
    public DataVisualizer ChangeData;
    //access slider GameObject
    public Slider SliderInstance;
    private object TimeStamp1;


    public void Start()
    {
        //define slider value range
        SliderInstance.minValue = 0;
        SliderInstance.maxValue = 10;
        SliderInstance.wholeNumbers = true;
        SliderInstance.value = 0; 
    }

    // Invoked when the value of the slider changes.
    public void ValueChange()
    {
        if (SliderInstance.value == 0)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(0);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 1)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(1);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 2)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(2);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 3)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(3);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 4)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(4);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 5)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(5);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 6)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(6);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 7)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(7);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 8)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(8);
            //Debug.Log(SliderInstance.value);
        }

        else if (SliderInstance.value == 9)
        {
            // select TimeStamp 1 in index from ActivateSeries
            ChangeData = FindObjectOfType<DataVisualizer>();
            ChangeData.ActivateSeries(9);
           // Debug.Log(SliderInstance.value);
        }

    }

}