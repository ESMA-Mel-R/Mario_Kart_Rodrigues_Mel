using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaceTurnNumerator : MonoBehaviour
{
    [SerializeField] private Text _LapNumber;
    [SerializeField] private Image _Finish;
    [SerializeField] private BoxCollider _BoxCollider;

    private int _number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _number = 0;
        _Finish = gameObject.GetComponent<Image>();
        _BoxCollider = GetComponent<BoxCollider>();
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
