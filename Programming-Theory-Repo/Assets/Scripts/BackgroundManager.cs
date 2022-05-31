using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0.0f, 0.0f));

        if(transform.position.x > 15)
        {
            transform.position = new Vector3(-25.0f, 0, 0);
        }
    }


}
