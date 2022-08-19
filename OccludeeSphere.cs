public struct OccludeeSphere // TypeDefIndex: 11504
{	// Fields
	public int id; // 0x0
	public OccludeeState state; // 0x8
	public OcclusionCulling.Sphere sphere; // 0x10

	// Properties
	public bool IsRegistered { get; }

	// Methods

	// RVA: 0xFBB50 Offset: 0xFAF50 VA: 0x1800FBB50
	public bool get_IsRegistered() { }

	// RVA: 0xFB9C0 Offset: 0xFADC0 VA: 0x1800FB9C0
	public void Invalidate() { }

	// RVA: 0xFBA80 Offset: 0xFAE80 VA: 0x1800FBA80
	public void .ctor(int id) { }

	// RVA: 0xFB9F0 Offset: 0xFADF0 VA: 0x1800FB9F0
	public void .ctor(int id, OcclusionCulling.Sphere sphere) { }

}

