using Fusion;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    private Vector3 _velocity;
    private bool _jumpPressed;
    public float JumpForce = 5f;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _jumpPressed = true;
        }
    }

    public override void FixedUpdateNetwork()
    {
        if (HasStateAuthority == false)
            return;

        if (_jumpPressed)
            _velocity.y += JumpForce;
        
        _jumpPressed = false;
    }
}