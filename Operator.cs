internal class Operator : AstNode // TypeDefIndex: 1796
{
	private static Operator.Op[] invertOp; 
	private Operator.Op opType; 
	private AstNode opnd1; 
	private AstNode opnd2; 

	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }


	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	public override AstNode.AstType get_Type() { }

	public override XPathResultType get_ReturnType() { }

	private static void .cctor() { }

}

public enum Operator.Op // TypeDefIndex: 1797
{
	public int value__; 
	public const Operator.Op INVALID = 0;
	public const Operator.Op OR = 1;
	public const Operator.Op AND = 2;
	public const Operator.Op EQ = 3;
	public const Operator.Op NE = 4;
	public const Operator.Op LT = 5;
	public const Operator.Op LE = 6;
	public const Operator.Op GT = 7;
	public const Operator.Op GE = 8;
	public const Operator.Op PLUS = 9;
	public const Operator.Op MINUS = 10;
	public const Operator.Op MUL = 11;
	public const Operator.Op DIV = 12;
	public const Operator.Op MOD = 13;
	public const Operator.Op UNION = 14;

}

