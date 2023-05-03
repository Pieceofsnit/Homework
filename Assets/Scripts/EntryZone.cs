using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryZone : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;

    private float _maxVolume = 1f;
    private float _minVolume = 0f;

    private void OnTriggerEnter(Collider colision)
    {
        if (colision.TryGetComponent<Player>(out Player player))
        {
            _alarm.TurnVolume(_maxVolume);
        }
    }

    private void OnTriggerExit(Collider colision)
    {
        _alarm.TurnVolume(_minVolume);
    }
}