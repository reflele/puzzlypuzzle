using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    GameObject stone;
    GameObject unmovableStone;

    void Start()
    {
        // CreateMap();
        customMapCreator(-20,-5,5);
    }

    public void CreateMap(){
        GameObject stone = GameObject.FindWithTag("Stone");
        

        float x = -112;
        float y = -5;
        float z = 0;

        float distance = 2;
        

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
            // GameObject position = Instantiate(stone, new Vector3(x, y, z), Quaternion.identity) as GameObject;
            
            
        Debug.Log(count);
        count++;
        }



    }

    // Instantiate(stone,new Vector3(x,y,z-distance),Quaternion.identity);

}}
    
    
    public void customMapCreator(int x, int y ,int z){
        // GameObject stone = GameObject.FindWithTag("Stone");
        
        float distance = 2;
        
        var position = new Vector3(x,y,z);
        // Instantiate(stone,position,Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-2),Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-4),Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-6),Quaternion.identity);
        // Instantiate(stone,new Vector3(x,y,z-8),Quaternion.identity);
        // Debug.Log("im in start");

        const int levelWidth = 10;
        const int levelHeight = 10;

        // int[,] array = new int[levelHeight,levelWidth]{
        //     {2,2,2,2,2,0,2,2,2,2,2,2},
        //     {2,1,1,2,0,0,0,1,2,2,2,2},
        //     {2,1,1,0,1,1,0,2,1,1,2,2},
        //     {2,1,1,1,0,1,1,0,0,1,1,2},
        //     {2,1,0,0,2,0,0,1,0,2,2,2},
        //     {2,1,0,1,2,2,2,2,2,2,2,2},
        //     {2,1,0,0,0,0,1,1,1,2,2,2},
        //     {2,0,1,0,1,1,1,1,0,1,2,2},
        //     {2,0,1,0,0,0,0,1,0,1,1,2},
        //     {2,2,2,2,2,2,2,2,1,2,2,2},
        // };

        NewBehaviourScript newBehaviourScript = new NewBehaviourScript();
        
        int[,] array = newBehaviourScript.CreateMatrix(levelWidth, levelHeight);
        newBehaviourScript.removeBlock(5, array);
        newBehaviourScript.removeBlock(25, array);
        newBehaviourScript.removeBlock(60, array);

        // int[,] array = new int[9,levelWidth]{
        //     {2,2,0,2,2,2,2,2,2,2,2,2},
        //     {2,2,0,2,2,0,0,0,2,2,2,2},
        //     {2,2,0,2,0,0,2,0,0,2,2,2},
        //     {2,2,0,2,0,2,0,0,0,0,2,2},
        //     {2,2,0,0,0,0,0,2,2,0,2,2},
        //     {2,2,2,2,2,2,0,2,2,2,2,2},
        //     {2,2,2,2,2,2,0,2,2,2,2,2},
        //     {2,2,2,2,2,2,0,0,0,2,2,2},
        //     {2,2,2,2,2,2,2,2,0,2,2,2},
        // };

        for (int row = 0; row < levelHeight;row++){
            for (int column = 0; column < levelWidth;column++){
                if (array[row,column] == 1){
                    stone = ObjectPool.instance.GetPooledStone();
                    if (stone != null)
                    {
                        stone.transform.position = new Vector3(x-(distance*row),y,z-(distance*column));
                        stone.transform.rotation = Quaternion.identity;
                        stone.SetActive(true);
                    }
                }
                if (array[row,column] == 2){
                    unmovableStone = ObjectPool.instance.GetPooledUnmovableStone();
                    if (unmovableStone != null)
                    {
                        unmovableStone.transform.position = new Vector3(x-(distance*row),y,z-(distance*column));
                        unmovableStone.transform.rotation = Quaternion.identity;
                        unmovableStone.SetActive(true);
                    }
                }
            }
        }}
    void Update()
    {

     
        
    }

}
