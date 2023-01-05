using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    void Start()
    {
        createMap();
    }

    public void createMap(){
        GameObject stone = GameObject.Find("Pushable Stone");

        float x = -112;
        float y = -5;
        float z = 0;

        float distance = 2;


        var position = new Vector3(x,y,z);
        // Instantiate(stone,position,Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-2),Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-4),Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-6),Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-8),Quaternion.identity);
        // Debug.Log("im in start");

        const int levelWidth = 5;
        const int levelHeight = 8;

        int[,] array = new int[levelHeight,levelWidth]{
            {1,1,0,1,1},
            {1,1,0,1,1},
            {1,0,1,1,1},
            {1,0,0,0,1},
            {0,1,0,1,1},
            {0,1,1,1,1},
            {1,0,0,0,1},
            {1,1,1,1,1}
            };
        
    int count = 0;
    for (int row = 0; row < levelHeight;row++){
            for (int column = 0; column < levelWidth;column++){
        if (array[row,column] == 1){
            Instantiate(stone,new Vector3(x-(distance*row),y,z-(distance*column)),Quaternion.identity);
            
            
        Debug.Log(count);
        count++;
        }



    }

    // Instantiate(stone,new Vector3(x,y,z-distance),Quaternion.identity);

}}



    // Update is called once per frame
    void Update()
    {

     
        
    }

}
