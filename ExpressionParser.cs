internal sealed class ExpressionParser // TypeDefIndex: 4251
{	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
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


	internal void .ctor(DataTable table) { }

	internal void LoadExpression(string data) { }

	internal void StartScan() { }

	internal ExpressionNode Parse() { }

	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	private ExpressionNode NodePop() { }

	private ExpressionNode NodePeek() { }

	private void NodePush(ExpressionNode node) { }

	private void BuildExpression(int pri) { }

	internal void CheckToken(Tokens token) { }

	internal Tokens Scan() { }

	private void ScanNumeric() { }

	private void ScanName() { }

	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	private void ScanDate() { }

	private void ScanBinaryConstant() { }

	private void ScanReserved() { }

	private void ScanString(char escape) { }

	internal void ScanToken(Tokens token) { }

	private void ScanWhite() { }

	private bool IsWhiteSpace(char ch) { }

	private bool IsAlphaNumeric(char ch) { }

	private bool IsDigit(char ch) { }

	private bool IsAlpha(char ch) { }

	private static void .cctor() { }

}

private struct ExpressionParser.ReservedWords // TypeDefIndex: 4252
{	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC


	internal void .ctor(string word, Tokens token, int op) { }

}

