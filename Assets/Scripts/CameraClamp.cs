using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    public float negativeXValue = -5.5f;
    public float positiveXValue = 5.5f;
    public float negativeYValue = -5.5f;
    public float positiveYValue = 5.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, negativeXValue, positiveXValue),
            Mathf.Clamp(targetToFollow.position.y, negativeYValue, positiveYValue),
            transform.position.z);
        //can also be used for character rather than using colliders
    }
}
