using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoundary : MonoBehaviour
{
    [SerializeField] GameObject leftBoundary;
    [SerializeField] GameObject rightBoundary;
    // Start is called before the first frame update
    void Start()
    {
        SetBoundary();
    }

    // Update is called once per frame
    void SetBoundary()
    {
        Vector3 point = new Vector3();

        //place right
        point = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + 40, 0, Camera.main.nearClipPlane));
        rightBoundary.transform.position = point;

        point = Camera.main.ScreenToWorldPoint(new Vector3(-40, 0, Camera.main.nearClipPlane));
        leftBoundary.transform.position = point;

    }
}
