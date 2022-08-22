public struct ViewModelDrawEvent : IEquatable<ViewModelDrawEvent> // TypeDefIndex: 11448
{	public ViewModelRenderer viewModelRenderer; // 0x0
	public Renderer renderer; // 0x8
	public bool skipDepthPrePass; // 0x10
	public Material material; // 0x18
	public int subMesh; // 0x20
	public int pass; // 0x24


	public bool Equals(ViewModelDrawEvent other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

