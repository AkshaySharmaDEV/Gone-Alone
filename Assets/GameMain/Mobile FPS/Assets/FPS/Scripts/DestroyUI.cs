using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUI : MonoBehaviour
{
    [SerializeField]
    GameObject objectToDestroy;

    // Start is called before the first frame update
    public void DestroyGameObject()
    {
        Destroy(objectToDestroy);
    }

    
}
