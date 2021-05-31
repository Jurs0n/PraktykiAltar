using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{

    Gracz postacGracza;

    private void Start()
    {
        postacGracza = FindObjectOfType<Gracz>();
    }

    void Update()
    {
        transform.position = new Vector3(postacGracza.transform.position.x, transform.position.y);
    }
}
