using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private void Update()
    {
        var position = gameObject.transform.position;
        Debug.Log(position);

        if (Input.GetKey(KeyCode.W))
        {
            var step = _speed * Time.deltaTime;
            position.z += step;
        }
        if (Input.GetKey(KeyCode.S))
        {
            var step = _speed * Time.deltaTime;
            position.z -= step;
        }

        if (Input.GetKey(KeyCode.A))
        {
            var step = _speed/5 * Time.deltaTime;
            position.x -= step;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var step = _speed/5 * Time.deltaTime;
            position.x += step;
        }
        
        transform.position = position;
        Debug.Log(position);
    }
}
