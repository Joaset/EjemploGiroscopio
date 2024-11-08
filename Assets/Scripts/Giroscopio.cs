using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giroscopio : MonoBehaviour
{
    Gyroscope m_Gyro;
    void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }

    void Update()
    {
        transform.Rotate(-m_Gyro.rotationRateUnbiased.x, -m_Gyro.rotationRateUnbiased.y, 0);
    }
}
