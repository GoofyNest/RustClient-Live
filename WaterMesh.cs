public class WaterMesh // TypeDefIndex: 10616
{	// Fields
	private Mesh borderMesh; // 0x10
	private Mesh centerPatch; // 0x18
	private int borderRingCount; // 0x20
	private float borderRingSpacingFalloff; // 0x24
	private int resolution; // 0x28
	private Vector3[] borderVerticesLocal; // 0x30
	private Vector3[] borderVerticesWorld; // 0x38
	private bool initialized; // 0x40

	// Properties
	public Mesh BorderMesh { get; }
	public Mesh CenterPatch { get; }
	public bool IsInitialized { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Mesh get_BorderMesh() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Mesh get_CenterPatch() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_IsInitialized() { }

	// RVA: 0xC14420 Offset: 0xC13820 VA: 0x180C14420
	public void Initialize(int patchResolution, float patchSizeInWorld, int borderRingCount, float borderRingSpacingFalloff) { }

	// RVA: 0xC143A0 Offset: 0xC137A0 VA: 0x180C143A0
	public void Destroy() { }

	// RVA: 0xC145E0 Offset: 0xC139E0 VA: 0x180C145E0
	public void UpdateBorderMesh(Matrix4x4 centerLocalToWorld, Matrix4x4 borderLocalToWorld, bool collapseCenter) { }

	// RVA: 0xC12D60 Offset: 0xC12160 VA: 0x180C12D60
	private Mesh CreateSortedBorderPatch(int resolution, int ringCount, float sizeInWorld) { }

	// RVA: 0xC13650 Offset: 0xC12A50 VA: 0x180C13650
	private Mesh CreateSortedCenterPatch(int resolution, float sizeInWorld, bool borderOnly) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

