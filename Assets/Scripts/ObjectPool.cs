using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    private List<GameObject> pooledStones = new List<GameObject>();
    private List<GameObject> pooledUnmovableStones = new List<GameObject>();
    
    
    private int stonesPoolCount = 100;
    private int unmovableStonesPoolCount = 100;

    [SerializeField] private GameObject stone;
    [SerializeField] private GameObject unmovableStone;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        for (int i = 0; i < stonesPoolCount; i++)
        {
            GameObject stoneObj = Instantiate(stone);
            stoneObj.SetActive(false);
            pooledStones.Add(stoneObj);
            if (i < unmovableStonesPoolCount)
            {
                GameObject unmovableStoneObj = Instantiate(unmovableStone);
                unmovableStoneObj.SetActive(false);
                pooledUnmovableStones.Add(unmovableStoneObj);
            }
        }
        
    }
    
    public GameObject GetPooledStone()
    {
        for (int i = 0; i < pooledStones.Count; i++)
        {
            if (!pooledStones[i].activeInHierarchy)
            {
                return pooledStones[i];
            }
         
        }
        return null;
        // Maybe increase maxStonesCount
    }    
    
    
    
    public GameObject GetPooledUnmovableStone()
    {
        for (int i = 0; i < pooledUnmovableStones.Count; i++)
        {
            if (!pooledUnmovableStones[i].activeInHierarchy)
            {
                return pooledUnmovableStones[i];
            }
        }
        return null;
        // Maybe increase maxStonesCount
    }
    
}