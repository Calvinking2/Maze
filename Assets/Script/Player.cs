using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMoveable, IControllable
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        //InputHandler1();

        GetComponent<IMoveable>();

        PositionUpdate();
        InputHandler();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<IMoveable>();
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log("Hit");
        }
    }
    public void PositionUpdate()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
    public void InputHandler()
    {

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        //direction.x = Input.GetAxis("Horizontal");
        //direction.y = Input.GetAxis("Vertical");
    }
    private void InputHandler1()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
    }
}
