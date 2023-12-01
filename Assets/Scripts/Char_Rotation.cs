using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Rotation : MonoBehaviour
{
    private float startingMousePosition;
    private Vector3 startingEulerAngles;

    public float rotationSpeed;
    public Vector3 rotationVector;
    public Vector2 mouseAxis;

    [Min(1)]
    public Vector3 stepAngle;


    // Start is called before the first frame update
    private void OnMouseDown()
    {
        startingMousePosition = (Input.mousePosition * mouseAxis).magnitude;
        startingEulerAngles = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    private void OnMouseDrag()
    {
        float distance = startingMousePosition - (Input.mousePosition * mouseAxis).magnitude;
        Vector3 newEulerAngles = startingEulerAngles + rotationVector * rotationSpeed * distance;
        newEulerAngles = new Vector3 (Mathf.RoundToInt(newEulerAngles.x / stepAngle.x) * stepAngle.x,
                                      Mathf.RoundToInt(newEulerAngles.y / stepAngle.y) * stepAngle.y,
                                      Mathf.RoundToInt(newEulerAngles.z / stepAngle.z) * stepAngle.z);
        transform.rotation = Quaternion.Euler(newEulerAngles);
    }
}
