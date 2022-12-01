internal abstract class AstNode // TypeDefIndex: 1787
{
	public abstract AstNode.AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }


	public abstract AstNode.AstType get_Type();

	public abstract XPathResultType get_ReturnType();

	protected void .ctor() { }

}

public enum AstNode.AstType // TypeDefIndex: 1788
{
	public int value__;
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

