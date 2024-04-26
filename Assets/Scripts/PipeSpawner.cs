using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	[SerializeField] GameObject pipeLinePrefab; // 프리팹
	[SerializeField] Transform spawnPoint; // 생성 포인트
	[SerializeField] float repeatTime; // 생성 
	[SerializeField] float randomRange; // 랜덤 범위

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
			// Debug.Log("파이프 스폰");
			
			Vector3 random = Vector3.up * Random.Range(-randomRange, randomRange); 
			// 위 아래의 랜덤 수치, 값에 방향을 곱해주면 벡터가 된다.

			Instantiate(pipeLinePrefab, spawnPoint.position + random, spawnPoint.rotation); // 위치, 회전 설정 안하면 기본 0, 0
		}
	}
}
