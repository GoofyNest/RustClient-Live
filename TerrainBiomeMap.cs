public class TerrainBiomeMap : TerrainMap<byte> // TypeDefIndex: 12143
{
	public Texture2D BiomeTexture; 
	internal int num; 


	public override void Setup() { }

	public void GenerateTextures() { }

	public void ApplyTextures() { }

	public float GetBiomeMax(Vector3 worldPos, int mask = -1) { }

	public float GetBiomeMax(float normX, float normZ, int mask = -1) { }

	public float GetBiomeMax(int x, int z, int mask = -1) { }

	public int GetBiomeMaxIndex(Vector3 worldPos, int mask = -1) { }

	public int GetBiomeMaxIndex(float normX, float normZ, int mask = -1) { }

	public int GetBiomeMaxIndex(int x, int z, int mask = -1) { }

	public int GetBiomeMaxType(Vector3 worldPos, int mask = -1) { }

	public int GetBiomeMaxType(float normX, float normZ, int mask = -1) { }

	public int GetBiomeMaxType(int x, int z, int mask = -1) { }

	public float GetBiome(Vector3 worldPos, int mask) { }

	public float GetBiome(float normX, float normZ, int mask) { }

	public float GetBiome(int x, int z, int mask) { }

	public void SetBiome(Vector3 worldPos, int id) { }

	public void SetBiome(float normX, float normZ, int id) { }

	public void SetBiome(int x, int z, int id) { }

	public void SetBiome(Vector3 worldPos, int id, float v) { }

	public void SetBiome(float normX, float normZ, int id, float v) { }

	public void SetBiome(int x, int z, int id, float v) { }

	public void SetBiomeRaw(int x, int z, Vector4 v, float opacity) { }

	private void SetBiome(int x, int z, int id, float old_val, float new_val) { }

	public void .ctor() { }

}

private sealed class TerrainBiomeMap.<>c__DisplayClass3_0 // TypeDefIndex: 12144
{
	public TerrainBiomeMap <>4__this; 
	public Color32[] col; 


	public void .ctor() { }

	internal void <GenerateTextures>

}

