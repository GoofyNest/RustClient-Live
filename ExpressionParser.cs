internal sealed class ExpressionParser // TypeDefIndex: 4251
{
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; 
	private char _escape; 
	private char _decimalSeparator; 
	private char _listSeparator; 
	private char _exponentL; 
	private char _exponentU; 
	internal char[] _text; 
	internal int _pos; 
	internal int _start; 
	internal Tokens _token; 
	internal int _op; 
	internal OperatorInfo[] _ops; 
	internal int _topOperator; 
	internal int _topNode; 
	private readonly DataTable _table; 
	internal ExpressionNode[] _nodeStack; 
	internal int _prevOperand; 
	internal ExpressionNode _expression; 


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
{
	internal readonly string _word; 
	internal readonly Tokens _token; 
	internal readonly int _op; 


internal void .ctor(string word, Tokens token, int op) { }

}

