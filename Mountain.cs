public class Mountain : TerrainPlacement // TypeDefIndex: 10589
{	// Fields
	public float Fade; // 0x110

	// Methods

	// RVA: 0x7B92B0 Offset: 0x7B86B0 VA: 0x1807B92B0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7B8290 Offset: 0x7B7690 VA: 0x1807B8290 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7B8780 Offset: 0x7B7B80 VA: 0x1807B8780 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7B7CD0 Offset: 0x7B70D0 VA: 0x1807B7CD0 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7B8E00 Offset: 0x7B8200 VA: 0x1807B8E00 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7B9540 Offset: 0x7B8940 VA: 0x1807B9540
	public void .ctor() { }

}

private sealed class Mountain.<>c__DisplayClass2_0 // TypeDefIndex: 10590
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CCE20 Offset: 0x7CC220 VA: 0x1807CCE20
	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass3_0 // TypeDefIndex: 10591
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68
	public TextureData splat0data; // 0x78
	public TextureData splat1data; // 0x88
	public bool should0; // 0x98
	public bool should1; // 0x99
	public bool should2; // 0x9A
	public bool should3; // 0x9B
	public bool should4; // 0x9C
	public bool should5; // 0x9D
	public bool should6; // 0x9E
	public bool should7; // 0x9F

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CD1F0 Offset: 0x7CC5F0 VA: 0x1807CD1F0
	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass5_0 // TypeDefIndex: 10592
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68
	public TextureData biomedata; // 0x78
	public bool should0; // 0x88
	public bool should1; // 0x89
	public bool should2; // 0x8A
	public bool should3; // 0x8B

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CD760 Offset: 0x7CCB60 VA: 0x1807CD760
	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass6_0 // TypeDefIndex: 10593
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public TextureData topologydata; // 0x58

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CDB90 Offset: 0x7CCF90 VA: 0x1807CDB90
	internal void <ApplyTopology>b__0(int x, int z) { }

}

