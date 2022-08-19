internal sealed class ExprException // TypeDefIndex: 4258
{	// Methods

	// RVA: 0x13DC7F0 Offset: 0x13DBBF0 VA: 0x1813DC7F0
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x13DC790 Offset: 0x13DBB90 VA: 0x1813DC790
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x13DC850 Offset: 0x13DBC50 VA: 0x1813DC850
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x13DC730 Offset: 0x13DBB30 VA: 0x1813DC730
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x13DC6D0 Offset: 0x13DBAD0 VA: 0x1813DC6D0
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x13DB900 Offset: 0x13DAD00 VA: 0x1813DB900
	public static Exception InvokeArgument() { }

	// RVA: 0x13DBCF0 Offset: 0x13DB0F0 VA: 0x1813DBCF0
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x13DBB10 Offset: 0x13DAF10 VA: 0x1813DBB10
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x13DBBE0 Offset: 0x13DAFE0 VA: 0x1813DBBE0
	public static Exception MissingOperator(string token) { }

	// RVA: 0x13DC0D0 Offset: 0x13DB4D0 VA: 0x1813DC0D0
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x13DB200 Offset: 0x13DA600 VA: 0x1813DB200
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x13DAFD0 Offset: 0x13DA3D0 VA: 0x1813DAFD0
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x13DC160 Offset: 0x13DB560 VA: 0x1813DC160
	public static Exception UnboundName(string name) { }

	// RVA: 0x13DB760 Offset: 0x13DAB60 VA: 0x1813DB760
	public static Exception InvalidString(string str) { }

	// RVA: 0x13DC1F0 Offset: 0x13DB5F0 VA: 0x1813DC1F0
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x13DBEB0 Offset: 0x13DB2B0 VA: 0x1813DBEB0
	public static Exception SyntaxError() { }

	// RVA: 0x13DB170 Offset: 0x13DA570 VA: 0x1813DB170
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x13DBC70 Offset: 0x13DB070 VA: 0x1813DBC70
	public static Exception MissingRightParen() { }

	// RVA: 0x13DC280 Offset: 0x13DB680 VA: 0x1813DC280
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x13DC350 Offset: 0x13DB750 VA: 0x1813DC350
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x13DAD90 Offset: 0x13DA190 VA: 0x1813DAD90
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x13DAE70 Offset: 0x13DA270 VA: 0x1813DAE70
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x13DB640 Offset: 0x13DAA40 VA: 0x1813DB640
	public static Exception InvalidName(string name) { }

	// RVA: 0x13DB3A0 Offset: 0x13DA7A0 VA: 0x1813DB3A0
	public static Exception InvalidDate(string date) { }

	// RVA: 0x13DBD80 Offset: 0x13DB180 VA: 0x1813DBD80
	public static Exception NonConstantArgument() { }

	// RVA: 0x13DB6D0 Offset: 0x13DAAD0 VA: 0x1813DB6D0
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x13DB320 Offset: 0x13DA720 VA: 0x1813DB320
	public static Exception InWithoutParentheses() { }

	// RVA: 0x13DB2A0 Offset: 0x13DA6A0 VA: 0x1813DB2A0
	public static Exception InWithoutList() { }

	// RVA: 0x13DB4B0 Offset: 0x13DA8B0 VA: 0x1813DB4B0
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x13DBE00 Offset: 0x13DB200 VA: 0x1813DBE00
	public static Exception Overflow(Type type) { }

	// RVA: 0x13DAB60 Offset: 0x13D9F60 VA: 0x1813DAB60
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x13DAA90 Offset: 0x13D9E90 VA: 0x1813DAA90
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x13DBFB0 Offset: 0x13DB3B0 VA: 0x1813DBFB0
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13DA970 Offset: 0x13D9D70 VA: 0x1813DA970
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x13DC610 Offset: 0x13DBA10 VA: 0x1813DC610
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x13DB5B0 Offset: 0x13DA9B0 VA: 0x1813DB5B0
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x13DBA80 Offset: 0x13DAE80 VA: 0x1813DBA80
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x13DBF30 Offset: 0x13DB330 VA: 0x1813DBF30
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x13DC4C0 Offset: 0x13DB8C0 VA: 0x1813DC4C0
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x13DAC70 Offset: 0x13DA070 VA: 0x1813DAC70
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x13DA860 Offset: 0x13D9C60 VA: 0x1813DA860
	public static Exception AggregateArgument() { }

	// RVA: 0x13DA8E0 Offset: 0x13D9CE0 VA: 0x1813DA8E0
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x13DAF50 Offset: 0x13DA350 VA: 0x1813DAF50
	public static Exception EvalNoContext() { }

	// RVA: 0x13DB050 Offset: 0x13DA450 VA: 0x1813DB050
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x13DAD00 Offset: 0x13DA100 VA: 0x1813DAD00
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x13DB0E0 Offset: 0x13DA4E0 VA: 0x1813DB0E0
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x13DB980 Offset: 0x13DAD80 VA: 0x1813DB980
	public static Exception LookupArgument() { }

	// RVA: 0x13DB870 Offset: 0x13DAC70 VA: 0x1813DB870
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x13DB430 Offset: 0x13DA830 VA: 0x1813DB430
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x13DB530 Offset: 0x13DA930 VA: 0x1813DB530
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x13DB7F0 Offset: 0x13DABF0 VA: 0x1813DB7F0
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x13DBA00 Offset: 0x13DAE00 VA: 0x1813DBA00
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x13DC560 Offset: 0x13DB960 VA: 0x1813DC560
	public static Exception UnsupportedDataType(Type type) { }

}

