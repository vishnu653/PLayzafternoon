using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartimemovemnt : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(+1f * Time.deltaTime, 0f, +1f);
    }
}
