using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Line : MonoBehaviour
{

    [SerializeField]
    LineRenderer lineRenderer;

    List<Vector2> points;

    void SetPoint(Vector2 point)
    {
        points.Add(point);
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
    }

    public void UpdateLine(Vector2 point)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoint(point);
            return;
        }

        if (Vector2.Distance(points.Last(), point) > .1f)
        {
            SetPoint(point);
        }
    }

}
