using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnerLogic : MonoBehaviour {

	public GameObject collectible;
	public GameObject badCollectible;

	public float collectibleSpawnTime = 1.0f;
	public float badCollectibleSpawnTime = 2.0f;

	public bool canSpawnCollectible = true;
	public bool canSpawnBadCollectible = true;

	float randomXCollectible = 0.0f;
	float randomYCollectible = 0.0f;

	float randomXBadCollectible = 0.0f;
	float randomYBadCollectible = 0.0f;

	float maxX = 12.5f;
	float maxY = 9.0f;

	void Start () {
		StartCoroutine (spawnCollectibles ());
		StartCoroutine (spawnBadCollectibles ());
	}
	

	void Update () {
		
	}

	IEnumerator spawnCollectibles() {
		while (canSpawnCollectible == true){
			spawnCollectible ();
			yield return new WaitForSeconds (collectibleSpawnTime);
		}
	}

	IEnumerator spawnBadCollectibles (){
		while ( canSpawnBadCollectible == true){
			spawnBadCollectible ();
			yield return new WaitForSeconds (badCollectibleSpawnTime);

		}
	}


	void spawnCollectible () {
		randomXCollectible = Random.Range (-maxX, maxX);
		randomYCollectible = Random.Range (-maxY, maxY);

		Instantiate (collectible, new Vector3 (randomXCollectible, randomYCollectible, 0), Quaternion.identity);
	}

	void spawnBadCollectible () {
		randomXBadCollectible = Random.Range (-maxX, maxX);
		randomYBadCollectible = Random.Range (-maxY, maxY);

		Instantiate (badCollectible, new Vector3 (randomXBadCollectible, randomYBadCollectible, 0), Quaternion.identity);
	}
}
