using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool _isFinishLine;
    private void OnTriggerEnter(Collider other)
    {
        var otherLapManager = other.GetComponent<LapManager>();
        if (otherLapManager != null)
        {

        }
    }
}
