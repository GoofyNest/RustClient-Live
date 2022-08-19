internal class Operator : AstNode // TypeDefIndex: 1796
{	// Fields
	private static Operator.Op[] invertOp; // 0x0
	private Operator.Op opType; // 0x10
	private AstNode opnd1; // 0x18
	private AstNode opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x12EF0B0 Offset: 0x12EE4B0 VA: 0x1812EF0B0
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x12EF110 Offset: 0x12EE510 VA: 0x1812EF110 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x12EF040 Offset: 0x12EE440 VA: 0x1812EF040
	private static void .cctor() { }

}

public enum Operator.Op // TypeDefIndex: 1797
{	// Fields
	public int value__; // 0x0
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

