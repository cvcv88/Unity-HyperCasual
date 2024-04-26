using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] Transform[] children; // �ڽĵ� transform �迭
    [SerializeField] float scrollSpeed; // ��ũ�� �ӵ�
    [SerializeField] float offset;

    private void Update()
    {
        for (int i = 0; i < children.Length; i++)
        {
            children[i].Translate(Vector2.left * scrollSpeed * Time.deltaTime, Space.World); // ���� ���� ����
            Debug.Log("�̵� ��");
            if(children[i].position.x < -offset)
            {
                Vector2 pos = new Vector2(offset, children[i].position.y); // y ����, x�� �ű��
                children[i].position = pos;
            }
        }
    }
}
