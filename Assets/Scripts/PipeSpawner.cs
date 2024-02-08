using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	[SerializeField] GameObject pipeLinePrefab; // ������
	[SerializeField] Transform spawnPoint; // ���� ����Ʈ
	[SerializeField] float repeatTime; // ���� 
	[SerializeField] float randomRange; // ���� ����

	private Coroutine coroutine;

	private void OnEnable()
	{
		coroutine = StartCoroutine(SpawnRoutine());
	}
	private void OnDisable()
	{
		StopCoroutine(coroutine);
	}
	IEnumerator SpawnRoutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(repeatTime);
			// Debug.Log("������ ����");
			
			Vector3 random = Vector3.up * Random.Range(-randomRange, randomRange); 
			// �� �Ʒ��� ���� ��ġ, ���� ������ �����ָ� ���Ͱ� �ȴ�.

			Instantiate(pipeLinePrefab, spawnPoint.position + random, spawnPoint.rotation); // ��ġ, ȸ�� ���� ���ϸ� �⺻ 0, 0
		}
	}
}
