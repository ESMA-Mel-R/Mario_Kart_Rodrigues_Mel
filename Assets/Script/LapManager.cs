using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    private int _lapNumber;
    private List<Checkpoint> _checkpoint;
    private int _numberOfCheckpoints;

    private void Start()
    {
        _numberOfCheckpoints = FindObjectsByType<Checkpoint>(FindObjectsSortMode.None).Length;
        _checkpoint = new List<Checkpoint>();
    }
    public void AddCheckpoint(Checkpoint checkpointToAdd)
    {
        if (checkpointToAdd._isFinishLine)
        {
            FinishLap();
        }

        if(_checkpoint.Contains(checkpointToAdd) == false)
        {
            _checkpoint.Add(checkpointToAdd);
        }
    }

    private void FinishLap()
    {
        if(_checkpoint.Count > _numberOfCheckpoints / 2)
        {
            _lapNumber++;
            Debug.Log("Tour fini, on entre dans le tour " + _lapNumber);
        }
    }
}
