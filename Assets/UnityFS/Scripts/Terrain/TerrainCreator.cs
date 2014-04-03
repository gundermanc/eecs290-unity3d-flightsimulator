using UnityEngine;
using System.Collections;

public class TerrainCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TerrainCreator.create (Terrain.activeTerrain.terrainData.heightmapResolution);
	}

	static void create(int size) {
		float[,] zeroes = new float[size, size];
		for(int i = 0; i < size; i++) {
			for(int j = 0; j < size; j++) {
				zeroes[i, j] = 0f;
			}
		}
		float[,] heights = new float[size - 10, size - 10];
		for(int i = 0; i < size - 10; i++) {
			for(int j = 0; j < size - 10; j++) {
				heights[i, j] = Random.Range(0f, 0.01f);
			}
		}
		Terrain.activeTerrain.terrainData.SetHeights (0, 0, zeroes);
		Terrain.activeTerrain.terrainData.SetHeights(5, 5, heights);
	}
}
