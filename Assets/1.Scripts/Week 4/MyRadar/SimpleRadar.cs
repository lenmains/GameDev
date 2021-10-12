using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRadar : MonoBehaviour
{
    [SerializeField] Transform sweepTransform;
    [SerializeField] float rotationSpeed;

    [SerializeField] private float radarDistance;
    [SerializeField] private List<Collider2D> colliderList;

    [SerializeField] private Transform pfRadarPing;

    private void Awake()
    {
        sweepTransform = transform.Find("Sweep");
        rotationSpeed = -180f;
        radarDistance = 4;
        colliderList = new List<Collider2D>();
    }

    private void Update()
    {
        float previousRotation = (sweepTransform.eulerAngles.z % 360) -180;
        sweepTransform.eulerAngles += new Vector3(0, 0, rotationSpeed * Time.deltaTime);
        float currentRotation = (sweepTransform.eulerAngles.z % 360) - 180;

        if (previousRotation < 0 && currentRotation >= 0)
        {
            colliderList.Clear();
        }

        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position,
            GetVectorFromAngle(sweepTransform.eulerAngles.z), radarDistance);
        if (raycastHit2D.collider != null)
        {
            if (!colliderList.Contains((raycastHit2D.collider)))
            {
                colliderList.Add(raycastHit2D.collider);
                RadarPing radarPing = Instantiate(pfRadarPing, raycastHit2D.point, Quaternion.identity).GetComponent<RadarPing>();

            }
        }

    }

    public static Vector3 GetVectorFromAngle(float angle)
    {
        float angleRad = angle * (Mathf.PI / 180f);
        return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
    }
}
