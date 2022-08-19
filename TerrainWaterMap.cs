public class TerrainWaterMap : TerrainMap<short> // TypeDefIndex: 10421
{	// Fields
	public Texture2D WaterTexture; // 0x48
	private float normY; // 0x50

	// Methods

	// RVA: 0x849880 Offset: 0x848C80 VA: 0x180849880 Slot: 4
	public override void Setup() { }

	// RVA: 0x847920 Offset: 0x846D20 VA: 0x180847920
	public void GenerateTextures() { }

	// RVA: 0x8478F0 Offset: 0x846CF0 VA: 0x1808478F0
	public void ApplyTextures() { }

	// RVA: 0x8487D0 Offset: 0x847BD0 VA: 0x1808487D0
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x8484A0 Offset: 0x8478A0 VA: 0x1808484A0
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x8481C0 Offset: 0x8475C0 VA: 0x1808481C0
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x848610 Offset: 0x847A10 VA: 0x180848610
	public float GetHeight(int x, int z) { }

	// RVA: 0x847EC0 Offset: 0x8472C0 VA: 0x180847EC0
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x847F20 Offset: 0x847320 VA: 0x180847F20
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x848170 Offset: 0x847570 VA: 0x180848170
	public float GetHeight01(int x, int z) { }

	// RVA: 0x848B00 Offset: 0x847F00 VA: 0x180848B00
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x848B90 Offset: 0x847F90 VA: 0x180848B90
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x848990 Offset: 0x847D90 VA: 0x180848990
	public Vector3 GetNormalFast(Vector2 uv) { }

	// RVA: 0x848E10 Offset: 0x848210 VA: 0x180848E10
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x849470 Offset: 0x848870 VA: 0x180849470
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x849580 Offset: 0x848980 VA: 0x180849580
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x849390 Offset: 0x848790 VA: 0x180849390
	public float GetSlope(int x, int z) { }

	// RVA: 0x849190 Offset: 0x848590 VA: 0x180849190
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x8490A0 Offset: 0x8484A0 VA: 0x1808490A0
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x8492B0 Offset: 0x8486B0 VA: 0x1808492B0
	public float GetSlope01(int x, int z) { }

	// RVA: 0x847AB0 Offset: 0x846EB0 VA: 0x180847AB0
	public float GetDepth(Vector3 worldPos) { }

	// RVA: 0x847CD0 Offset: 0x8470D0 VA: 0x180847CD0
	public float GetDepth(float normX, float normZ) { }

	// RVA: 0x849790 Offset: 0x848B90 VA: 0x180849790
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x8496E0 Offset: 0x848AE0 VA: 0x1808496E0
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x849660 Offset: 0x848A60 VA: 0x180849660
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x849B90 Offset: 0x848F90 VA: 0x180849B90
	public void .ctor() { }

}

private sealed class TerrainWaterMap.<>c__DisplayClass3_0 // TypeDefIndex: 10422
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainWaterMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x854760 Offset: 0x853B60 VA: 0x180854760
	internal void <GenerateTextures>b__0(int z) { }

}

