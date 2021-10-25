using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleMarioAnimation : MonoBehaviour
{
    IEnumerator EvalCurve()
    {

        float t = 0.0f;

        while (true)
        {
            while (t < 1.0f)
            {
                t += Time.deltaTime;
                //transform.position = new Vector3(curve.Evaluate(t), 0, 0);
                yield return null;
            }
        }
        Debug.Log(("We are Done!"));
        yield return null;
    }
}
