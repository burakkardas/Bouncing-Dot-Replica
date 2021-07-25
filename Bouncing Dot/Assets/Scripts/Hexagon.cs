using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate() {
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
        ));

        _mousePos.x = Mathf.Clamp(_mousePos.x, -2.8f, 2.8f);

        if(Input.GetMouseButtonDown(0) && _mousePos.x < 0) {
            transform.Rotate(0f, 0f, 30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0f, 0f, 30f);
        }
        else if(Input.GetMouseButtonDown(0) && _mousePos.x > 0) {
            transform.Rotate(0f, 0f, -30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0f, 0f, -30f);
        }
        yield return null;
    }
}
