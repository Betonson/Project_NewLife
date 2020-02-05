using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMovements : MonoBehaviour
{
    public GameObject target;

    [Range(0.01f, 1.0f)] public float smoothFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }
}
