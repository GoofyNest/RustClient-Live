public class TerrainAlphaMap : TerrainMap<byte> // TypeDefIndex: 12120
{
	[FormerlySerializedAsAttribute] 
	public Texture2D AlphaTexture; 


	public override void Setup() { }

	public void GenerateTextures() { }

	public void ApplyTextures() { }

	public float GetAlpha(Vector3 worldPos) { }

	public float GetAlpha(float normX, float normZ) { }

	public float GetAlpha(int x, int z) { }

	public void SetAlpha(Vector3 worldPos, float a) { }

	public void SetAlpha(float normX, float normZ, float a) { }

	public void SetAlpha(int x, int z, float a) { }

	public void SetAlpha(int x, int z, float a, float opacity) { }

	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	public void .ctor() { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass2_0 // TypeDefIndex: 12121
{
	public TerrainAlphaMap <>4__this; 
	public Color32[] col; 


	public void .ctor() { }

	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass12_0 // TypeDefIndex: 12122
{
	public float opacity; 
	public TerrainAlphaMap <>4__this; 
	public float a; 


	public void .ctor() { }

	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

