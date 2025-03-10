using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorSelf : MonoBehaviour
{
    public float Speed = 0.1f;
    
    private Vector3 direction;

    //定义枚举的值有哪些
    public enum RotateDirection
    {
        X轴正方向,
        X轴负方向,
        Y轴正方向,
        Y轴负方向,
        Z轴正方向,
        Z轴负方向,
    }

    public RotateDirection dir = RotateDirection.Y轴正方向;

    void Start()
    {
        switch (dir)
        {
            case RotateDirection.X轴正方向:
                direction = Vector3.right;
                break;
            case RotateDirection.X轴负方向:
                direction = Vector3.left;
                break;
            case RotateDirection.Y轴正方向:
                direction = Vector3.up;
                break;
            case RotateDirection.Y轴负方向:
                direction = Vector3.down;
                break;
            case RotateDirection.Z轴正方向:
                direction = Vector3.forward;
                break;
            case RotateDirection.Z轴负方向:
                direction = Vector3.back;
                break;
        }
    }

    void Update()
    {
        transform.Rotate(direction, Speed, Space.World);
    }
}
