public class TerrainHeightMap : TerrainMap<short> // TypeDefIndex: 12157
{
	public Texture2D HeightTexture;
	public Texture2D NormalTexture;
	private float normY;


	public override void Setup() { }

	public void ApplyToTerrain() { }

	public void GenerateTextures(bool heightTexture = True, bool normalTexture = True) { }

	public void ApplyTextures() { }

	public float GetHeight(Vector3 worldPos) { }

	public float GetHeight(float normX, float normZ) { }

	public float GetHeightFast(Vector2 uv) { }

	public float GetHeight(int x, int z) { }

	public float GetHeight01(Vector3 worldPos) { }

	public float GetHeight01(float normX, float normZ) { }

	public float GetTriangulatedHeight01(float normX, float normZ) { }

	public float GetHeight01(int x, int z) { }

	private float GetSrcHeight01(int x, int z) { }

	private float GetDstHeight01(int x, int z) { }

	public Vector3 GetNormal(Vector3 worldPos) { }

	public Vector3 GetNormal(float normX, float normZ) { }

	public Vector3 GetNormal(int x, int z) { }

	private Vector3 GetNormalSobel(int x, int z) { }

	public float GetSlope(Vector3 worldPos) { }

	public float GetSlope(float normX, float normZ) { }

	public float GetSlope(int x, int z) { }

	public float GetSlope01(Vector3 worldPos) { }

	public float GetSlope01(float normX, float normZ) { }

	public float GetSlope01(int x, int z) { }

	public void SetHeight(Vector3 worldPos, float height) { }

	public void SetHeight(float normX, float normZ, float height) { }

	public void SetHeight(int x, int z, float height) { }

	public void SetHeight(Vector3 worldPos, float height, float opacity) { }

	public void SetHeight(float normX, float normZ, float height, float opacity) { }

	public void SetHeight(int x, int z, float height, float opacity) { }

	public void AddHeight(Vector3 worldPos, float delta) { }

	public void AddHeight(float normX, float normZ, float delta) { }

	public void AddHeight(int x, int z, float delta) { }

	public void LowerHeight(Vector3 worldPos, float height, float opacity) { }

	public void LowerHeight(float normX, float normZ, float height, float opacity) { }

	public void LowerHeight(int x, int z, float height, float opacity) { }

	public void RaiseHeight(Vector3 worldPos, float height, float opacity) { }

	public void RaiseHeight(float normX, float normZ, float height, float opacity) { }

	public void RaiseHeight(int x, int z, float height, float opacity) { }

	public void SetHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	public void SetHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	public void LowerHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	public void LowerHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	public void RaiseHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	public void RaiseHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	public void AddHeight(Vector3 worldPos, float delta, float radius, float fade = 0) { }

	public void AddHeight(float normX, float normZ, float delta, float radius, float fade = 0) { }

	public void .ctor() { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass4_0 // TypeDefIndex: 12158
{
	public float[,] heights;
	public TerrainHeightMap <>4__this;


	public void .ctor() { }

	internal void <ApplyToTerrain>

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_0 // TypeDefIndex: 12159
{
	public Color32[] heights;
	public TerrainHeightMap <>4__this;


	public void .ctor() { }

	internal void <GenerateTextures>

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_1 // TypeDefIndex: 12160
{
	public int normalres;
	public Color32[] normals;
	public TerrainHeightMap <>4__this;


	public void .ctor() { }

	internal void <GenerateTextures>

}

private sealed class TerrainHeightMap.<>c__DisplayClass43_0 // TypeDefIndex: 12161
{
	public TerrainHeightMap <>4__this;
	public float height;
	public float opacity;


	public void .ctor() { }

	internal void <SetHeight>

}

private sealed class TerrainHeightMap.<>c__DisplayClass45_0 // TypeDefIndex: 12162
{
	public TerrainHeightMap <>4__this;
	public float height;
	public float opacity;


	public void .ctor() { }

	internal void <LowerHeight>

}

private sealed class TerrainHeightMap.<>c__DisplayClass47_0 // TypeDefIndex: 12163
{
	public TerrainHeightMap <>4__this;
	public float height;
	public float opacity;


	public void .ctor() { }

	internal void <RaiseHeight>

}

private sealed class TerrainHeightMap.<>c__DisplayClass49_0 // TypeDefIndex: 12164
{
	public TerrainHeightMap <>4__this;
	public float delta;


	public void .ctor() { }

	internal void <AddHeight>

}

