public class TerrainTopologyMap : TerrainMap<int> // TypeDefIndex: 10428
{
	public Texture2D TopologyTexture; 


	public override void Setup() { }

	public void GenerateTextures() { }

	public void ApplyTextures() { }

	public bool GetTopology(Vector3 worldPos, int mask) { }

	public bool GetTopology(float normX, float normZ, int mask) { }

	public bool GetTopology(int x, int z, int mask) { }

	public int GetTopology(Vector3 worldPos) { }

	public int GetTopology(float normX, float normZ) { }

	public int GetTopologyFast(Vector2 uv) { }

	public int GetTopology(int x, int z) { }

	public void SetTopology(Vector3 worldPos, int mask) { }

	public void SetTopology(float normX, float normZ, int mask) { }

	public void SetTopology(int x, int z, int mask) { }

	public void AddTopology(Vector3 worldPos, int mask) { }

	public void AddTopology(float normX, float normZ, int mask) { }

	public void AddTopology(int x, int z, int mask) { }

	public void RemoveTopology(Vector3 worldPos, int mask) { }

	public void RemoveTopology(float normX, float normZ, int mask) { }

	public void RemoveTopology(int x, int z, int mask) { }

	public int GetTopology(Vector3 worldPos, float radius) { }

	public int GetTopology(float normX, float normZ, float radius) { }

	public void SetTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	public void SetTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	public void AddTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	public void AddTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	public void .ctor() { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass2_0 // TypeDefIndex: 10429
{
	public Color32[] col; 
	public TerrainTopologyMap <>4__this; 


	public void .ctor() { }

	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass23_0 // TypeDefIndex: 10430
{
	public TerrainTopologyMap <>4__this; 
	public int mask; 


	public void .ctor() { }

	internal void <SetTopology>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass25_0 // TypeDefIndex: 10431
{
	public TerrainTopologyMap <>4__this; 
	public int mask; 


	public void .ctor() { }

	internal void <AddTopology>b__0(int x, int z, float lerp) { }

}

