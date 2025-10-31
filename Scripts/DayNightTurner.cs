using UnityEngine;

public class DayNightTurner : MonoBehaviour
{
    public int dayTimeInSce = 60;
    private float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotationSpeed = 360f/ dayTimeInSce;
    }

    private void FixedUpdate() // 方向光应该永远转半圈，这个问题之后再处理吧
    {
        transform.Rotate(0, rotationSpeed, 0);
        // transform.Rotate(0, transform.localRotation * rotationSpeed * Time.fixedDeltaTime, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
