internal class Filter : AstNode // TypeDefIndex: 1791
{	// Fields
	private AstNode input; // 0x10
	private AstNode condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

