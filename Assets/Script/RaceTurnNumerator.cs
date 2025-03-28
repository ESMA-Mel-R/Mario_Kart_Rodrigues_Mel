using System.Collections;
using UnityEngine;

public class RaceTurnNumerator : MonoBehaviour
{
    private int _number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ( _number == 4)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "Car")
        {
            StartCoroutine(Turn());
        }
    }

    IEnumerator Turn()
    {
        _number += 1;
        yield return new WaitForSeconds(5);
    }
}
