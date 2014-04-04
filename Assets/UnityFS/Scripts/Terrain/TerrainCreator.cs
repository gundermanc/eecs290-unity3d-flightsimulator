using UnityEngine;
using System.Collections;

public class TerrainCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TerrainCreator.create (Terrain.activeTerrain.terrainData.heightmapResolution);
	}

	static void create(int size) {
		float center = size / 2f;
		float[,] heights = new float[size, size];
		for(int i = 0; i < size - 10; i++) {
			for(int j = 0; j < size - 10; j++) {
				float r = Mathf.Sqrt(Mathf.Pow(center - i, 2) + Mathf.Pow(center - j, 2));
				if (r > 10)
					heights[i, j] = Mathf.Sqrt(2f/(r-5)) + Random.Range(0f, 0.01f);
				if (r > 300)
					heights[i, j] -= (r-300)*0.01f;
			}
		}
		Terrain.activeTerrain.terrainData.SetHeights(0, 0, heights);
	}
}
