using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _recoveryRate;

    private Coroutine _volumeChange;
    private float _minVolume = 0f;
    private float _targetValue;
    private float _currValue;

    private void PlaySound()
    {
        _audioSource.Play();
    }

    private void StopSound()
    {
        _audioSource.Stop();
    }

    public void TurnVolume(float targetVolume)
    {
        _targetValue = targetVolume;

        if (_volumeChange != null)
        {
            StopCoroutine(_volumeChange);
        } 
        _volumeChange = StartCoroutine(ChangeVolumeSound());
    }

    public IEnumerator ChangeVolumeSound()
    {
        if (_targetValue > _minVolume)
            PlaySound();

        while (_targetValue != _currValue)
        {
            _currValue = Mathf.MoveTowards(_currValue, _targetValue, _recoveryRate * Time.deltaTime);
            _audioSource.volume = _currValue;
            yield return null;
            
            if(_currValue == _minVolume)
                StopSound();
        }
    }
}
