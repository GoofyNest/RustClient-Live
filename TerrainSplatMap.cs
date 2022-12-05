public class TerrainSplatMap : TerrainMap<byte> // TypeDefIndex: 12171
{
	public Texture2D SplatTexture0;
	public Texture2D SplatTexture1;
	internal int num;


	public override void Setup() { }

	public void GenerateTextures() { }

	public void ApplyTextures() { }

	public float GetSplatMax(Vector3 worldPos, int mask = -1) { }

	public float GetSplatMax(float normX, float normZ, int mask = -1) { }

	public float GetSplatMax(int x, int z, int mask = -1) { }

	public int GetSplatMaxIndex(Vector3 worldPos, int mask = -1) { }

	public int GetSplatMaxIndex(float normX, float normZ, int mask = -1) { }

	public int GetSplatMaxIndex(int x, int z, int mask = -1) { }

	public int GetSplatMaxType(Vector3 worldPos, int mask = -1) { }

	public int GetSplatMaxType(float normX, float normZ, int mask = -1) { }

	public int GetSplatMaxType(int x, int z, int mask = -1) { }

	public float GetSplat(Vector3 worldPos, int mask) { }

	public float GetSplat(float normX, float normZ, int mask) { }

	public float GetSplat(int x, int z, int mask) { }

	public void SetSplat(Vector3 worldPos, int id) { }

	public void SetSplat(float normX, float normZ, int id) { }

	public void SetSplat(int x, int z, int id) { }

	public void SetSplat(Vector3 worldPos, int id, float v) { }

	public void SetSplat(float normX, float normZ, int id, float v) { }

	public void SetSplat(int x, int z, int id, float v) { }

	public void SetSplatRaw(int x, int z, Vector4 v1, Vector4 v2, float opacity) { }

	public void SetSplat(Vector3 worldPos, int id, float opacity, float radius, float fade = 0) { }

	public void SetSplat(float normX, float normZ, int id, float opacity, float radius, float fade = 0) { }

	public void AddSplat(Vector3 worldPos, int id, float delta, float radius, float fade = 0) { }

	public void AddSplat(float normX, float normZ, int id, float delta, float radius, float fade = 0) { }

	private void SetSplat(int x, int z, int id, float old_val, float new_val) { }

	public void .ctor() { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_0 // TypeDefIndex: 12172
{
	public Color32[] cols;
	public TerrainSplatMap <>4__this;


	public void .ctor() { }

	internal void <GenerateTextures>

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_1 // TypeDefIndex: 12173
{
	public Color32[] cols;
	public TerrainSplatMap <>4__this;


	public void .ctor() { }

	internal void <GenerateTextures>

}

private sealed class TerrainSplatMap.<>c__DisplayClass26_0 // TypeDefIndex: 12174
{
	public TerrainSplatMap <>4__this;
	public int idx;
	public float opacity;
	public int id;


	public void .ctor() { }

	internal void <SetSplat>

}

private sealed class TerrainSplatMap.<>c__DisplayClass28_0 // TypeDefIndex: 12175
{
	public TerrainSplatMap <>4__this;
	public int idx;
	public float delta;
	public int id;


	public void .ctor() { }

	internal void <AddSplat>

}

