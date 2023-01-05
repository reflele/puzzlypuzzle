using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableStonesScript : MonoBehaviour
{
    // Start is called before the first frame update
    Transform stonesPosition;
    Vector3 defaultPosition;
    [SerializeField] List<GameObject> individualStones;

    private List<Vector3> individualStonesPositions = new List<Vector3>();

    void Start()
    {
        // Debug.Log("pushablestonesscript start");
        stonesPosition = GetComponent<Transform>();

        defaultPosition = stonesPosition.GetComponent<Transform>().localPosition;

        for(int i = 0; i < individualStones.Count; i++){
            // Debug.Log("Got run" + i.ToString());
            individualStonesPositions.Add(individualStones[i].GetComponent<Transform>().localPosition);
        }
    }

    public void ResetStones(){
        
        stonesPosition.transform.position = defaultPosition;
        // Debug.Log("inside resetStones method");

        for(int i = 0; i < individualStones.Count; i++)
        {
            individualStones[i].GetComponent<Transform>().localPosition = individualStonesPositions[i];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
