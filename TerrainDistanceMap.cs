public class TerrainDistanceMap : TerrainMap<byte> // TypeDefIndex: 10397
{	// Fields
	public Texture2D DistanceTexture; // 0x48

	// Methods

	// RVA: 0x113A3B0 Offset: 0x11397B0 VA: 0x18113A3B0 Slot: 4
	public override void Setup() { }

	// RVA: 0x1139C30 Offset: 0x1139030 VA: 0x181139C30
	public void GenerateTextures() { }

	// RVA: 0x8478F0 Offset: 0x846CF0 VA: 0x1808478F0
	public void ApplyTextures() { }

	// RVA: 0x1139EB0 Offset: 0x11392B0 VA: 0x181139EB0
	public Vector2i GetDistance(Vector3 worldPos) { }

	// RVA: 0x1139DD0 Offset: 0x11391D0 VA: 0x181139DD0
	public Vector2i GetDistance(float normX, float normZ) { }

	// RVA: 0x113A0A0 Offset: 0x11394A0 VA: 0x18113A0A0
	public Vector2i GetDistance(int x, int z) { }

	// RVA: 0x113A1F0 Offset: 0x11395F0 VA: 0x18113A1F0
	public void SetDistance(int x, int z, Vector2i v) { }

	// RVA: 0x113A600 Offset: 0x1139A00 VA: 0x18113A600
	public void .ctor() { }

}

private sealed class TerrainDistanceMap.<>c__DisplayClass2_0 // TypeDefIndex: 10398
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainDistanceMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x114FDE0 Offset: 0x114F1E0 VA: 0x18114FDE0
	internal void <GenerateTextures>b__0(int z) { }

}

