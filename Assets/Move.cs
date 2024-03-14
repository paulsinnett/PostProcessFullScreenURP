using UnityEngine;

public class Move : MonoBehaviour
{
    Vector2 rotations;
    public float speed = 90f;

    void Update()
    {
        rotations += new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotations.y, rotations.x, 0f);
    }
}
