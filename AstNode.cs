internal abstract class AstNode // TypeDefIndex: 1787
{	// Properties
	public abstract AstNode.AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AstNode.AstType get_Type();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XPathResultType get_ReturnType();

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public enum AstNode.AstType // TypeDefIndex: 1788
{	// Fields
	public int value__; // 0x0
	public const AstNode.AstType Axis = 0;
	public const AstNode.AstType Operator = 1;
	public const AstNode.AstType Filter = 2;
	public const AstNode.AstType ConstantOperand = 3;
	public const AstNode.AstType Function = 4;
	public const AstNode.AstType Group = 5;
	public const AstNode.AstType Root = 6;
	public const AstNode.AstType Variable = 7;
	public const AstNode.AstType Error = 8;

}

