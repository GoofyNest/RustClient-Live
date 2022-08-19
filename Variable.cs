internal class Variable : AstNode // TypeDefIndex: 1799
{	// Fields
	private string localname; // 0x10
	private string prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string name, string prefix) { }

	// RVA: 0xB9B120 Offset: 0xB9A520 VA: 0x180B9B120 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

