using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;

[CreateAssetMenu(fileName = "TargetTransform", menuName = "ThisGame/Target/TargetTransform", order = 1)]

public class TargetTransform : ScriptableObject
{
    
    [SerializeField] private float _rotation;

    [SerializeField] private float _size;

    [SerializeField] private int _rotationDirection;

    public float Rotation { get => _rotation; set => _rotation = value; }
    public float Size { get => _size; set => _size = value; }

    public int RotationDirection { get => _rotationDirection; set => _rotationDirection = value; }






}


