using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 50.0f;
    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
      _rigidbody = GetComponent<Rigidbody2D>();
    }

}
