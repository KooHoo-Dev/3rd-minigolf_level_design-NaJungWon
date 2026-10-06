using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    public Vector3 axis;
    public float rotateSpeed = 60f;

    private void Update()
    {
        Vector3 rotVector = axis.normalized;
        transform.Rotate(rotVector, rotateSpeed * Time.deltaTime,  Space.Self);
    }
}
