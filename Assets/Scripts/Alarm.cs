using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    public AudioSource audioSource;

    public void PlaySound()
    {
        audioSource.Play();
>>>>>>> 68991fcdd4c81519d79bc27ed3e39eebb28e4635
    }

    public void StopSound()
    {
<<<<<<< HEAD
        _audioSource.Stop();
    }

    public IEnumerator ChangeVolumeSound()
    {
        while (_targetValue != _currValue)
        {
            Debug.Log("Worked");
            _currValue = Mathf.MoveTowards(_currValue, _targetValue, _recoveryRate * Time.deltaTime);
            _audioSource.volume = _currValue;
            yield return null;
        }

        _targetValue = _minVolume;

        if (_currValue == _minVolume)
        {
            StopSound();
            Debug.Log("Stop");
        }
=======
        audioSource.Stop();
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
>>>>>>> 68991fcdd4c81519d79bc27ed3e39eebb28e4635
    }
}
