using UnityEngine;
using UnityEngine.Networking;

public class EnemySpawner : NetworkBehaviour 
{
	public GameObject enemyPrefab;
	public int numberOfEnemies;

	public override void OnStartServer()
	{
		for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-20.0f, 20.0f), 0, Random.Range(-20.0f, 20.0f));
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = spawnPosition;
            enemy.transform.rotation = Quaternion.Euler(0, Random.Range(0, 180), 0);
            NetworkServer.Spawn(enemy);
		}
	}
}
