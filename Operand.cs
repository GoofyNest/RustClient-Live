internal class Operand : AstNode // TypeDefIndex: 1795
{	private XPathResultType type; // 0x10
	private object val; // 0x18

	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }


	public void .ctor(string val) { }

	public void .ctor(double val) { }

	public override AstNode.AstType get_Type() { }

	public override XPathResultType get_ReturnType() { }

}

