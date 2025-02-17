using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour
{

    private Camera mainCamera;
    private Vector3 worldPosition;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        worldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0;
        transform.position = worldPosition;
    }
     void FixedUpdate() 
    {
        rb.MovePosition(worldPosition);
    }
}
