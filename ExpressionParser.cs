internal sealed class ExpressionParser // TypeDefIndex: 4251
{	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x13E0100 Offset: 0x13DF500 VA: 0x1813E0100
	internal void .ctor(DataTable table) { }

	// RVA: 0x13DCFD0 Offset: 0x13DC3D0 VA: 0x1813DCFD0
	internal void LoadExpression(string data) { }

	// RVA: 0x13DFBC0 Offset: 0x13DEFC0 VA: 0x1813DFBC0
	internal void StartScan() { }

	// RVA: 0x13DD6F0 Offset: 0x13DCAF0 VA: 0x1813DD6F0
	internal ExpressionNode Parse() { }

	// RVA: 0x13DD240 Offset: 0x13DC640 VA: 0x1813DD240
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x13DD120 Offset: 0x13DC520 VA: 0x1813DD120
	private ExpressionNode NodePop() { }

	// RVA: 0x13DD0D0 Offset: 0x13DC4D0 VA: 0x1813DD0D0
	private ExpressionNode NodePeek() { }

	// RVA: 0x13DD170 Offset: 0x13DC570 VA: 0x1813DD170
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x13DCAB0 Offset: 0x13DBEB0 VA: 0x1813DCAB0
	private void BuildExpression(int pri) { }

	// RVA: 0x13DCDD0 Offset: 0x13DC1D0 VA: 0x1813DCDD0
	internal void CheckToken(Tokens token) { }

	// RVA: 0x13DF510 Offset: 0x13DE910 VA: 0x1813DF510
	internal Tokens Scan() { }

	// RVA: 0x13DEDF0 Offset: 0x13DE1F0 VA: 0x1813DEDF0
	private void ScanNumeric() { }

	// RVA: 0x13DEB90 Offset: 0x13DDF90 VA: 0x1813DEB90
	private void ScanName() { }

	// RVA: 0x13DEC70 Offset: 0x13DE070 VA: 0x1813DEC70
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x13DEA00 Offset: 0x13DDE00 VA: 0x1813DEA00
	private void ScanDate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void ScanBinaryConstant() { }

	// RVA: 0x13DF060 Offset: 0x13DE460 VA: 0x1813DF060
	private void ScanReserved() { }

	// RVA: 0x13DF350 Offset: 0x13DE750 VA: 0x1813DF350
	private void ScanString(char escape) { }

	// RVA: 0x13DF480 Offset: 0x13DE880 VA: 0x1813DF480
	internal void ScanToken(Tokens token) { }

	// RVA: 0x13DF4B0 Offset: 0x13DE8B0 VA: 0x1813DF4B0
	private void ScanWhite() { }

	// RVA: 0x13DCFC0 Offset: 0x13DC3C0 VA: 0x1813DCFC0
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x13DCE50 Offset: 0x13DC250 VA: 0x1813DCE50
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x13DCF70 Offset: 0x13DC370 VA: 0x1813DCF70
	private bool IsDigit(char ch) { }

	// RVA: 0x13DCEF0 Offset: 0x13DC2F0 VA: 0x1813DCEF0
	private bool IsAlpha(char ch) { }

	// RVA: 0x13DFC90 Offset: 0x13DF090 VA: 0x1813DFC90
	private static void .cctor() { }

}

private struct ExpressionParser.ReservedWords // TypeDefIndex: 4252
{	// Fields
	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC

	// Methods

	// RVA: 0xF9C90 Offset: 0xF9090 VA: 0x1800F9C90
	internal void .ctor(string word, Tokens token, int op) { }

}

