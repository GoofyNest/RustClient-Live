public class TerrainWaterMap : TerrainMap<short> // TypeDefIndex: 12150
{
	public Texture2D WaterTexture; 
	private float normY; 


	public override void Setup() { }

	public void GenerateTextures() { }

	public void ApplyTextures() { }

	public float GetHeight(Vector3 worldPos) { }

	public float GetHeight(float normX, float normZ) { }

	public float GetHeightFast(Vector2 uv) { }

	public float GetHeight(int x, int z) { }

	public float GetHeight01(Vector3 worldPos) { }

	public float GetHeight01(float normX, float normZ) { }

	public float GetHeight01(int x, int z) { }

	public Vector3 GetNormal(Vector3 worldPos) { }

	public Vector3 GetNormal(float normX, float normZ) { }

	public Vector3 GetNormalFast(Vector2 uv) { }

	public Vector3 GetNormal(int x, int z) { }

	public float GetSlope(Vector3 worldPos) { }

	public float GetSlope(float normX, float normZ) { }

	public float GetSlope(int x, int z) { }

	public float GetSlope01(Vector3 worldPos) { }

	public float GetSlope01(float normX, float normZ) { }

	public float GetSlope01(int x, int z) { }

	public float GetDepth(Vector3 worldPos) { }

	public float GetDepth(float normX, float normZ) { }

	public void SetHeight(Vector3 worldPos, float height) { }

	public void SetHeight(float normX, float normZ, float height) { }

	public void SetHeight(int x, int z, float height) { }

	public void .ctor() { }

}

private sealed class TerrainWaterMap.<>c__DisplayClass3_0 // TypeDefIndex: 12151
{
	public Color32[] heights; 
	public TerrainWaterMap <>4__this; 


	public void .ctor() { }

	internal void <GenerateTextures>b__0(int z) { }

}

