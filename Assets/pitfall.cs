using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitfall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = GameObject.Find("maze").transform;
    }


}
