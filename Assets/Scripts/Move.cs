using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 0.1f;
    public Vector3 Target;
    UnityEngine.Camera cam;
    public bool reached = false;

    void Start()
    {
        cam = UnityEngine.Camera.main;
        Target = GenerateTarget();
    }

    void Update()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(transform.position);
        if (transform.position == Target || !(viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1 && viewPos.z > 0))
        {
            Target = GenerateTarget();
        }
        transform.position = Vector3.MoveTowards(transform.position, Target, Speed);

    }

    Vector3 GenerateTarget()
    {
        Vector3 Target = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        return Target;
    }
}
