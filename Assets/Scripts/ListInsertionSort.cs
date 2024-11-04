using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    List<int> numberList = new List<int> { 7, 1, 9, 6, 0 };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Original List:" + ListToString(numberList));
        InsertionSortList(numberList);
        Debug.Log("Sirted List:"+ ListToString(numberList));
    }
    void InsertionSortList(List<int> list)
    {
        int n = list.Count;
        for (int i = 1; i < n; i++)
        {
            int key = list[i];
            int j = i - 1;
            while (j >= 0 && list[j] > key)
            {
                list[j+1] = list[j];
                j = j - 1;
            }

            list[j + 1] = key;
        }
        
      

    }
    // Update is called once per frame
    
    
    string ListToString(List<int> list)
    {
        return string.Join(", ", list);
    }
}