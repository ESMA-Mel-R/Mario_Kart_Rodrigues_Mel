using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaceTurnNumerator : MonoBehaviour
{
    [SerializeField] private Text _LapNumber;
    [SerializeField] private Image _Finish;
    [SerializeField] private BoxCollider _BoxCollider;

    private int _Checks;
    private int _Lap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _Lap = 31;
        _LapNumber = GetComponent<Text>();
        _Checks = 0;
        _BoxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        _LapNumber.text = _Lap.ToString();

        if ( _Checks == 32)
        {
            _Lap += 1;
            _Checks = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "Checkpoint")
        {
            StartCoroutine(Turn());
        }
    }

    IEnumerator Turn()
    {
        _Checks += 1;
        yield return new WaitForSeconds(5);
    }
}
