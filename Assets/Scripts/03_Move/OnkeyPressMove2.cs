using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

// キーを押すと移動する
public class OnKeyPressMove2 : MonoBehaviour
{

    public float speed = 5f; //速度

    private Vector2 moveInput;
    private Rigidbody2D rbody;
    private SpriteRenderer sr;

    void Awake()
    {

    }
}