using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    GameObject stone;
    GameObject unmovableStone;
    [SerializeField] private GameObject floor;

    void Start()
    {
        var array = customMapCreator(5,5);
        generateMap(-31,-5,2,array);

        Vector3 floor1Pos = new Vector3(-36f, -6f,-4f);
        GameObject floor1 = Instantiate(this.floor, floor1Pos, Quaternion.identity);
        floor1.transform.localScale = new Vector3(18f, 1f, 14f);
        floor1.tag = "Floor";

        BoxCollider floor1Collider = floor1.AddComponent<BoxCollider>();
        floor1Collider.isTrigger = true;
        floor1Collider.size = new Vector3(1f, 1f, 1f);
        floor1Collider.center = new Vector3(0f, 0.5f, 0f);
        floor1Collider.tag = "Level1";

        var array2 = customMapCreator(7,7);
        generateMap(-11,-5,4,array2);
// -x = ned
// +x = op
// -z = højre
// +z = venstrea

        GameObject floor2 = Instantiate(this.floor, new Vector3(-16.87f, -6f,-4f), Quaternion.identity);
        floor2.transform.localScale = new Vector3(22.22f, 1f, 18.16f);
        floor2.tag = "Floor";

        BoxCollider floor2Collider = floor2.AddComponent<BoxCollider>();
        floor2Collider.isTrigger = true;
        floor2Collider.size = new Vector3(1f, 1f, 1f);
        floor2Collider.center = new Vector3(0f, 0.5f, 0f);
        floor2Collider.tag = "Level2";

        var array3 = customMapCreator(9,9);
        generateMap(13,-5,6,array3);
        GameObject floor3 = Instantiate(this.floor, new Vector3(4.71f, -6f,-4f), Quaternion.identity);
        floor3.transform.localScale = new Vector3(25.43f, 1f, 22f);
        floor3.tag = "Floor";

        BoxCollider floor3Collider = floor3.AddComponent<BoxCollider>();
        floor3Collider.isTrigger = true;
        floor3Collider.size = new Vector3(1f, 1f, 1f);
        floor3Collider.center = new Vector3(0f, 0.5f, 0f);
        floor3Collider.tag = "Level3";

        var array4 = customMapCreator(11,11);
        generateMap(41,-5,8,array4);
        GameObject floor4 = Instantiate(this.floor, new Vector3(30.59f, -6f,-4f), Quaternion.identity);
        floor4.transform.localScale = new Vector3(28.81f, 1f, 25.43f);
        floor4.tag = "Floor";

        BoxCollider floor4Collider = floor4.AddComponent<BoxCollider>();
        floor4Collider.isTrigger = true;
        floor4Collider.size = new Vector3(1f, 1f, 1f);
        floor4Collider.center = new Vector3(0f, 0.5f, 0f);
        floor4Collider.tag = "Level4";

        var array5 = customMapCreator(13, 13);
        generateMap(73, -5, 10, array5);
        GameObject floor5 = Instantiate(this.floor, new Vector3(60.74f, -6f, -4f), Quaternion.identity);
        floor5.transform.localScale = new Vector3(33.3f, 1f, 29.53f);
        floor5.tag = "Floor";

        BoxCollider floor5Collider = floor5.AddComponent<BoxCollider>();
        floor5Collider.isTrigger = true;
        floor5Collider.size = new Vector3(1f, 1f, 1f);
        floor5Collider.center = new Vector3(0f, 0.5f, 0f);
        floor5Collider.tag = "Level5";

// Create array6 and generate map
        var array6 = customMapCreator(15, 15);
        generateMap(109, -5, 12, array6);

// Create floor6 and set its properties
        GameObject floor6 = Instantiate(this.floor, new Vector3(94.6f, -6f, -4f), Quaternion.identity);
        floor6.transform.localScale = new Vector3(37.14f, 1f, 33.7f);
        floor6.tag = "Floor";

        BoxCollider floor6Collider = floor6.AddComponent<BoxCollider>();
        floor6Collider.isTrigger = true;
        floor6Collider.size = new Vector3(1f, 1f, 1f);
        floor6Collider.center = new Vector3(0f, 0.5f, 0f);
        floor6Collider.tag = "Level6";
        
// Create array7 and generate map
        var array7 = customMapCreator(17, 17);
        generateMap(149, -5, 14, array7);

// Create floor7 and set its properties
        GameObject floor7 = Instantiate(this.floor, new Vector3(132.54f, -6f, -4f), Quaternion.identity);
        floor7.transform.localScale = new Vector3(40.74f, 1f, 38.06f);
        floor7.tag = "Floor";

        BoxCollider floor7Collider = floor7.AddComponent<BoxCollider>();
        floor7Collider.isTrigger = true;
        floor7Collider.size = new Vector3(1f, 1f, 1f);
        floor7Collider.center = new Vector3(0f, 0.5f, 0f);
        floor7Collider.tag = "Level7";
        
        // Create array8 and generate map
        var array8 = customMapCreator(19, 19);
        generateMap(193, -5, 16, array8);

// Create floor8 and set its properties
        GameObject floor8 = Instantiate(this.floor, new Vector3(174.36f, -6f, -4f), Quaternion.identity);
        floor8.transform.localScale = new Vector3(44.44f, 1f, 41.92f);
        floor8.tag = "Floor";

        BoxCollider floor8Collider = floor8.AddComponent<BoxCollider>();
        floor8Collider.isTrigger = true;
        floor8Collider.size = new Vector3(1f, 1f, 1f);
        floor8Collider.center = new Vector3(0f, 0.5f, 0f);
        floor8Collider.tag = "Level8";

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


    public int[,] customMapCreator(int levelWidth, int levelHeight)
    {
        // GameObject stone = GameObject.FindWithTag("Stone");

        float distance = 2;

        

        // NewBehaviourScript newBehaviourScript = new NewBehaviourScript();
        GenerateMaze gn = new GenerateMaze();
        int count = 1;
        int num = 0;
        int[,] array = gn.CreateMatrixOfTwos(levelHeight, levelWidth);

        try
        {
            while (true)
            {
                if (!gn.IsSolvable(array))
                {
                    count++;
                    print("count: " + count);
                    num = gn.randomNumber(levelWidth, levelHeight);
                    print("num: " + num);
        
                    gn.removeBlock(num, array);
                }
                else
                {
break;
        
                }
        
            }
        
        }
        catch
        {
            print("caught");
        }
        

        array = gn.PadEdges(array);
        return array;

    }

    public void generateMap(int x, int y, int z, int[,] matrix)
    {

        float distance = 2;
        int levelHeight = matrix.GetLength(0);
        
        int levelWidth = matrix.GetLength(1);
        
            for (int row = 0; row < levelHeight; row++)
            {
                for (int column = 0; column < levelWidth; column++)
                {
                    if (matrix[row, column] == 1)
                    {
                        stone = ObjectPool.instance.GetPooledStone();
                        if (stone != null)
                        {
                            stone.transform.position = new Vector3(x - (distance * row), y, z - (distance * column));
                            stone.transform.rotation = Quaternion.identity;
                            stone.SetActive(true);
                        }
                    }

                    if (matrix[row, column] == 2)
                    {
                        unmovableStone = ObjectPool.instance.GetPooledUnmovableStone();
                        if (unmovableStone != null)
                        {
                            unmovableStone.transform.position =
                                new Vector3(x - (distance * row), y, z - (distance * column));
                            unmovableStone.transform.rotation = Quaternion.identity;
                            unmovableStone.SetActive(true);
                        }
                    }
                }
            }
        }
    

    void Update()
    {

     
        
    }

}
