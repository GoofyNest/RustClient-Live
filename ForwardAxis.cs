internal class ForwardAxis // TypeDefIndex: 2136
{	// Fields
	private DoubleLinkAxis topNode; // 0x10
	private DoubleLinkAxis rootNode; // 0x18
	private bool isAttribute; // 0x20
	private bool isDss; // 0x21
	private bool isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	internal bool get_IsAttribute() { }

	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	internal bool get_IsDss() { }

	// RVA: 0xB0BBA0 Offset: 0xB0AFA0 VA: 0x180B0BBA0
	internal bool get_IsSelfAxis() { }

	// RVA: 0xB0BA50 Offset: 0xB0AE50 VA: 0x180B0BA50
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

}

