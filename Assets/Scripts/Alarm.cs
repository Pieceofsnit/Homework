using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _recoveryRate;

    private float _maxVolume = 1f;
    private float _minVolume = 0f;
    private float _targetValue;
    private float _currValue;

    public void PlaySound()
    {
        _targetValue = _maxVolume;
        _audioSource.Play();
    }

    public void StopSound()
    {
        _audioSource.Stop();
    }

    public IEnumerator ChangeVolumeSound()
    {
        while (_targetValue != _currValue)
        {
            _currValue = Mathf.MoveTowards(_currValue, _targetValue, _recoveryRate * Time.deltaTime);
            _audioSource.volume = _currValue;
            yield return null;
        }
        _targetValue = _minVolume;

        if (_currValue == _minVolume)
        {
            StopSound();
        }
    }
}
