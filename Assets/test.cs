using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed = 5f; // �ړ����x

    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody �R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody���A�^�b�`����Ă��܂���I");
        }
    }

    void FixedUpdate()
    {
        // ���L�[�̓��͂��擾
        float moveHorizontal = Input.GetAxis("Horizontal"); // ���E�L�[
        float moveVertical = Input.GetAxis("Vertical");   // �㉺�L�[

        // ���͂Ɋ�Â��Ĉړ��x�N�g�����v�Z
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Rigidbody���g�p���ċ����ړ�
        rb.AddForce(movement * moveSpeed);
    }
}