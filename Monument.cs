public class Monument : TerrainPlacement // TypeDefIndex: 10583
{	// Fields
	public float Radius; // 0x110
	public float Fade; // 0x114

	// Methods

	// RVA: 0x77C6A0 Offset: 0x77BAA0 VA: 0x18077C6A0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77B5E0 Offset: 0x77A9E0 VA: 0x18077B5E0 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77BBE0 Offset: 0x77AFE0 VA: 0x18077BBE0 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77ABC0 Offset: 0x779FC0 VA: 0x18077ABC0 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77B0A0 Offset: 0x77A4A0 VA: 0x18077B0A0 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77C1C0 Offset: 0x77B5C0 VA: 0x18077C1C0 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77C7E0 Offset: 0x77BBE0 VA: 0x18077C7E0
	public void .ctor() { }

}

private sealed class Monument.<>c__DisplayClass3_0 // TypeDefIndex: 10584
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public bool useBlendMap; // 0x58
	public TextureData blenddata; // 0x60
	public Vector3 position; // 0x70
	public TextureData heightdata; // 0x80

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x77D350 Offset: 0x77C750 VA: 0x18077D350
	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass4_0 // TypeDefIndex: 10585
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData splat0data; // 0x58
	public TextureData splat1data; // 0x68
	public bool should0; // 0x78
	public bool should1; // 0x79
	public bool should2; // 0x7A
	public bool should3; // 0x7B
	public bool should4; // 0x7C
	public bool should5; // 0x7D
	public bool should6; // 0x7E
	public bool should7; // 0x7F

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x77D790 Offset: 0x77CB90 VA: 0x18077D790
	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass5_0 // TypeDefIndex: 10586
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData alphadata; // 0x58

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x77DCA0 Offset: 0x77D0A0 VA: 0x18077DCA0
	internal void <ApplyAlpha>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass6_0 // TypeDefIndex: 10587
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData biomedata; // 0x58
	public bool should0; // 0x68
	public bool should1; // 0x69
	public bool should2; // 0x6A
	public bool should3; // 0x6B

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x77DFD0 Offset: 0x77D3D0 VA: 0x18077DFD0
	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass7_0 // TypeDefIndex: 10588
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData topologydata; // 0x58

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x77E380 Offset: 0x77D780 VA: 0x18077E380
	internal void <ApplyTopology>b__0(int x, int z) { }

}

