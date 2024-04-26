using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UIElements;


public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] Animator animator;

    [Header("Specs")]
    // [SerializeField] float jumpPower;
	[SerializeField] float jumpSpeed;
	[SerializeField] float moveSpeed;

    [Header("Events")]
    public UnityEvent OnDied;

	private void Update()
	{
        Rotate();
	}
    private void Rotate()
    {
        transform.right = rigid.velocity + Vector2.right * moveSpeed;
    }
	private void Jump()
    {
        // ���� ���� �ӵ� ���� (���ӹ��) - ������ �ӵ� ��ȭ
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // �ӵ��� ���� ���� (�ӵ��������)
        rigid.velocity = Vector2.up * jumpSpeed;
    }
    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Jump();
        }
    }

    private void Die()
    {
		Debug.Log("����");
		animator.SetBool("Die", true);
        OnDied?.Invoke();
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("�浹");
        // if (��ֹ��� �ε�����)
        Die();
    }
}
