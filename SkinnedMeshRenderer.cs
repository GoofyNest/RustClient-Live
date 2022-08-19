public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 3436
{	// Properties
	public bool updateWhenOffscreen { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativePropertyAttribute] // RVA: 0x96470 Offset: 0x95870 VA: 0x180096470
	public Mesh sharedMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x96560 Offset: 0x95960 VA: 0x180096560
	public bool skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x19B1210 Offset: 0x19B0610 VA: 0x1819B1210
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x19B13E0 Offset: 0x19B07E0 VA: 0x1819B13E0
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x19B1150 Offset: 0x19B0550 VA: 0x1819B1150
	public Transform get_rootBone() { }

	// RVA: 0x19B12F0 Offset: 0x19B06F0 VA: 0x1819B12F0
	public void set_rootBone(Transform value) { }

	// RVA: 0x19B10A0 Offset: 0x19B04A0 VA: 0x1819B10A0
	public Transform[] get_bones() { }

	// RVA: 0x19B1250 Offset: 0x19B0650 VA: 0x1819B1250
	public void set_bones(Transform[] value) { }

	// RVA: 0x19B1190 Offset: 0x19B0590 VA: 0x1819B1190
	public Mesh get_sharedMesh() { }

	// RVA: 0x19B1340 Offset: 0x19B0740 VA: 0x1819B1340
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x19B11D0 Offset: 0x19B05D0 VA: 0x1819B11D0
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x19B1390 Offset: 0x19B0790 VA: 0x1819B1390
	public void set_skinnedMotionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x963C0 Offset: 0x957C0 VA: 0x1800963C0
	// RVA: 0x19B0FA0 Offset: 0x19B03A0 VA: 0x1819B0FA0
	private Bounds GetLocalAABB() { }

	// RVA: 0x19B1050 Offset: 0x19B0450 VA: 0x1819B1050
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x19B10E0 Offset: 0x19B04E0 VA: 0x1819B10E0
	public Bounds get_localBounds() { }

	// RVA: 0x19B12A0 Offset: 0x19B06A0 VA: 0x1819B12A0
	public void set_localBounds(Bounds value) { }

	// RVA: 0x19B0F50 Offset: 0x19B0350 VA: 0x1819B0F50
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x19B1000 Offset: 0x19B0400 VA: 0x1819B1000
	private void SetLocalAABB_Injected(ref Bounds b) { }

}

