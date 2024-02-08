using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] Transform[] children; // 자식들 transform 배열
    [SerializeField] float scrollSpeed; // 스크롤 속도
    [SerializeField] float offset;

    private void Update()
    {
        for (int i = 0; i < children.Length; i++)
        {
            children[i].Translate(Vector2.left * scrollSpeed * Time.deltaTime, Space.World); // 세상 기준 왼쪽
            Debug.Log("이동 중");
            if(children[i].position.x < -offset)
            {
                Vector2 pos = new Vector2(offset, children[i].position.y); // y 유지, x만 옮기기
                children[i].position = pos;
            }
        }
    }
}
