using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryZone : MonoBehaviour
{
    [SerializeField] public float recoveryRate;

    public Alarm _alarm;
    private float _currValue;
    private float _targetValue;
    private float _maxVolume = 1f;
    private float _minVolume = 0f;

    private IEnumerator ChangeVolumeSound()
    {
        while (_targetValue != _currValue)
        {
            _currValue = Mathf.MoveTowards(_currValue, _targetValue, recoveryRate * Time.deltaTime);
            _alarm.ChangeVolume(_currValue);
            yield return null;
        }

        if (_currValue == _minVolume)
        {
            _alarm.StopSound();
        }
    }

    private void OnTriggerEnter(Collider colision)
    {
        if (colision.TryGetComponent<Player>(out Player player))
        {
            _targetValue = _maxVolume;
            _alarm.PlaySound();
            StartCoroutine(ChangeVolumeSound());
        }
    }

    private void OnTriggerExit(Collider colision)
    {
        _targetValue = _minVolume;
        StartCoroutine(ChangeVolumeSound());
    }
}
