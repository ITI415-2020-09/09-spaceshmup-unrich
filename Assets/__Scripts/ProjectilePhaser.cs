using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePhaser : Projectile
{
    public float ProjectileBrithTime;
    public float speed;
    public float x0;
    public float waveFrequency; 
    public float waveWidth;

    void Start()
    {
        speed = 10f;
        ProjectileBrithTime = Time.time;
        x0 = this.transform.position.x;
        waveFrequency = 2;
        waveWidth = 4;
    }
    void FixedUpdate()
    {
        Vector3 tempPos = this.transform.position;

        float age = Time.time - ProjectileBrithTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        tempPos.x = x0 + waveWidth * sin;
        tempPos.y += Time.deltaTime * speed;//add speed
        this.transform.position = tempPos;
    }
}
