public struct ViewModelDrawEvent : IEquatable<ViewModelDrawEvent> // TypeDefIndex: 11448
{	// Fields
	public ViewModelRenderer viewModelRenderer; // 0x0
	public Renderer renderer; // 0x8
	public bool skipDepthPrePass; // 0x10
	public Material material; // 0x18
	public int subMesh; // 0x20
	public int pass; // 0x24

	// Methods

	// RVA: 0xF8480 Offset: 0xF7880 VA: 0x1800F8480 Slot: 4
	public bool Equals(ViewModelDrawEvent other) { }

	// RVA: 0xF84C0 Offset: 0xF78C0 VA: 0x1800F84C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF8570 Offset: 0xF7970 VA: 0x1800F8570 Slot: 2
	public override int GetHashCode() { }

}

