using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;


    private float _xSpeed;
    private float _ySpeed;

    public float speed = 3;

    private string Inputx = "Horizontal";
    private string Inputy = "Vertical";

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xSpeed = Input.GetAxis(Inputx);
        _ySpeed = Input.GetAxis(Inputy);

        _rigidbody2D. velocity = new Vector2 (_xSpeed, _ySpeed) * speed;
        
    }


}


