using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField]
    public static Point[] points;

    void Awake()
    {
        points = new Point[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i).GetComponent<Point>();
        }
    }
}
