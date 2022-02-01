public class Charactor2DController : MonoBehavior
{


    public float MovementSpeed =,1;

    private Rigidbody2D _rigidbody; 

    private void Start ()
    {
        _rigidbody = GetCompont<Rigidbody2D>();
    }

    private void Update()
    {
       
       var movement = Input.GetAxis("Horizontal");
       transform position += new Vector3(movement 0,0) * Time.deltaTime * MovementSpeed;

       if (!Mathf.Approximately(0, movement))
          transform.rotation = movement > 0 ? Quaterion.Euler(0, 180, 0) : Quaterion.identity;

       if(Input.GetButtonDown("Jump") && Mathf .Abs(_rigidbody.velocity.y) < 0.001f)
       {
           _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D ForceMode2D.Impulse);
       }
    }
}