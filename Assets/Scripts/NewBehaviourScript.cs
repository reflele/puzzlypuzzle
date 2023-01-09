using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[,] CreateMatrix(int width, int length)
    {
        int[,] matrix = new int[width, length];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                matrix[i, j] = 2;
            }
        }
        return matrix;
    }
    

    // public void removeBlock (int value, int[,] matrix)
    // {
    //     int width = matrix.GetLength(0);
    //     int length = matrix.GetLength(1);
    //     int row = (value - 1) / length;
    //     int col = (value - 1) % length;
    //     matrix[row, col] = 0;
    //     
    // }
    //
    // private int randomNumber(int width, int length)
    // {
    //     int maxNumber = (width * length) + 1;
    //     int randomNumber = UnityEngine.Random.Range(0, maxNumber);
    //     return randomNumber;
    // }
    
}
