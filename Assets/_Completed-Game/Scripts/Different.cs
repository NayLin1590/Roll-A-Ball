using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Different : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Debug.Log("Fixed Update" + Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(" Update" + Time.deltaTime);
    }
    void LateUpdate()
    {
        Debug.Log("Late Update" + Time.deltaTime);
    }
}
