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
            _alarm.ChangeVolumeSound();
            _alarm.PlaySound();
        }
    }

    private void OnTriggerExit(Collider colision)
    {
        _alarm.ChangeVolumeSound();
    }
}
