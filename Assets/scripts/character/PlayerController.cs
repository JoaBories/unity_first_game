using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float JumpForce = 5f;
    bool walking = false;
    bool jumping = false;
    bool canjump = true;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D Rigid = GetComponent<Rigidbody2D>();
        Animator anim = GetComponent<Animator>();
        SpriteRenderer spriteRender = GetComponent<SpriteRenderer>();

        if (Input.GetKey(KeyCode.D)){
            spriteRender.flipX = false;
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            walking = true;
            anim.SetBool("walking", walking);
        }
        if (Input.GetKey(KeyCode.A)){
            spriteRender.flipX = true;
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            walking = true;
            anim.SetBool("walking", walking);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canjump)
            {
                jumping = true;
                anim.SetBool("jumping", jumping);
                Rigid.velocity = new Vector2(0, JumpForce);
                canjump = false;
            }
        }
        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            walking = false;
            anim.SetBool("walking", walking);
        }
        if (Rigid.velocity == Vector2.zero)
        {
            jumping = false;
            canjump = true;
            anim.SetBool("jumping", jumping);
        }

    }
}
