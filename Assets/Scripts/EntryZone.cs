using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryZone : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private Alarm _alarm;
=======
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
>>>>>>> 68991fcdd4c81519d79bc27ed3e39eebb28e4635

    private void OnTriggerEnter(Collider colision)
    {
        if (colision.TryGetComponent<Player>(out Player player))
        {
<<<<<<< HEAD
            _alarm.PlaySound();
            StartCoroutine(_alarm.ChangeVolumeSound());
            Debug.Log("Play");
=======
            _targetValue = _maxVolume;
            _alarm.PlaySound();
            StartCoroutine(ChangeVolumeSound());
>>>>>>> 68991fcdd4c81519d79bc27ed3e39eebb28e4635
        }
    }

    private void OnTriggerExit(Collider colision)
    {
<<<<<<< HEAD
        StartCoroutine(_alarm.ChangeVolumeSound());
    }
}
=======
        _targetValue = _minVolume;
        StartCoroutine(ChangeVolumeSound());
    }
}
>>>>>>> 68991fcdd4c81519d79bc27ed3e39eebb28e4635
