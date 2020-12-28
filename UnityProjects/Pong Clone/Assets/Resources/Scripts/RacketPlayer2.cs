using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    public float playerMovementSpeed;

    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * playerMovementSpeed;
    }
}
