using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    [SerializeField] private Transform rotationPivot_;
    [SerializeField] private float rotationAroundSpeed_;
    [SerializeField] private float rotationSelfSpeed_;

    private void Update()
    {
        if(rotationPivot_ != null) transform.RotateAround(rotationPivot_.position, Vector3.up, rotationAroundSpeed_ * Time.deltaTime);
        transform.Rotate(transform.up * rotationSelfSpeed_ * Time.deltaTime); 
    }

}
