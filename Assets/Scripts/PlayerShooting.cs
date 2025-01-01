using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private Transform aimTransform;
    private Vector3 mousePosition;
    public Camera sceneCamera;
    private void Awake()
    {
        aimTransform = transform.Find("GunParent");
    }
    private void Update()
    {
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
        Debug.Log(angle);
    }
    
}
