using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnabler : MonoBehaviour
{
    [SerializeField] private Transform rightSpikesTransform;
    [SerializeField] private Transform leftSpikesTransform;
    private List<GameObject> rightSpikesList = new List<GameObject>();
    private List<GameObject> leftSpikesList = new List<GameObject>();

    void Start()
    {
        foreach (Transform child in rightSpikesTransform)
        {
            rightSpikesList.Add(child.gameObject);
        }
        foreach (Transform child in leftSpikesTransform)
        {
            leftSpikesList.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
