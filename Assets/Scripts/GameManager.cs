
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Target[] targets;
    private int[] hpValues;

    private void Start()
    {
       
        targets = FindObjectsOfType<Target>();
        hpValues = new int[targets.Length];
        for (int i = 0; i < targets.Length; i++)
        {
            hpValues[i] = targets[i].GetHealthPoints();
        }

        targets = BubbleSortArray(targets);
    }
    Target[] BubbleSortArray(Target[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - i; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j]. GetHealthPoints() > array[j + 1]. GetHealthPoints())
                {
                    Target temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    
                }
            }
        }
        return array;
    }

    public int[] GetSortHPValues()
    {
        return hpValues;
    }
    
} 
