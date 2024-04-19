using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public Action<Vector2> OnGunShoot;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void HandleGunShoot(Vector2 aimPoint)
    {
        OnGunShoot?.Invoke(aimPoint.normalized);
    }
}
