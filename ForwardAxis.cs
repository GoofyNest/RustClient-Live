internal class ForwardAxis // TypeDefIndex: 2136
{	private DoubleLinkAxis topNode; // 0x10
	private DoubleLinkAxis rootNode; // 0x18
	private bool isAttribute; // 0x20
	private bool isDss; // 0x21
	private bool isSelfAxis; // 0x22

	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }


	internal DoubleLinkAxis get_RootNode() { }

	internal DoubleLinkAxis get_TopNode() { }

	internal bool get_IsAttribute() { }

	internal bool get_IsDss() { }

	internal bool get_IsSelfAxis() { }

	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

}

