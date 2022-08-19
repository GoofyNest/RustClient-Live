internal class Operand : AstNode // TypeDefIndex: 1795
{	// Fields
	private XPathResultType type; // 0x10
	private object val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x12EEF90 Offset: 0x12EE390 VA: 0x1812EEF90
	public void .ctor(string val) { }

	// RVA: 0x12EEFD0 Offset: 0x12EE3D0 VA: 0x1812EEFD0
	public void .ctor(double val) { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 5
	public override XPathResultType get_ReturnType() { }

}

