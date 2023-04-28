using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryZone : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;

    private void OnTriggerEnter(Collider colision)
    {
        if (colision.TryGetComponent<Player>(out Player player))
        {
            _alarm.PlaySound();
            StartCoroutine(_alarm.ChangeVolumeSound());
        }
    }

    private void OnTriggerExit(Collider colision)
    {
        StartCoroutine(_alarm.ChangeVolumeSound());
    }
}
