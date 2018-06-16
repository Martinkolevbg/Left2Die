using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public enum GunType { Semi, Brust, Auto };
    public GunType gunType;

    public Transform spawn;

    public void Shoot()
    {
        Ray ray = new Ray(spawn.position, spawn.forward);
        RaycastHit hit;

        float shotDistance = 20;

        if (Physics.Raycast(ray, out hit, shotDistance))
        {
            shotDistance = hit.distance;
        }
        Debug.DrawRay(ray.origin, ray.direction * shotDistance, Color.red, 1);

    }
    void shootContinuos()
    {
        if(gunType == GunType.Auto)
        {
            Shoot();
        }
    }

}