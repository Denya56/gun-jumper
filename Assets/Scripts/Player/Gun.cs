using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Camera camera;
    public Vector3 aimPoint;
    private void Awake()
    {
        camera = Camera.main;
    }

    void Update()
    {
        aimPoint = camera.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            EventManager.Instance.HandleGunShoot(new Vector2(aimPoint.x, aimPoint.y));
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        //Gizmos.DrawWireSphere(ray.origin, 0.5f);
        /*Gizmos.color = Color.black;
        Gizmos.DrawLine(transform.position, ray.origin);*/
        //Gizmos.DrawRay(ray);
    }
}
