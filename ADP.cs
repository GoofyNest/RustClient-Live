internal static class ADP // TypeDefIndex: 4368
{
	private static readonly Type s_stackOverflowType;
	private static readonly Type s_outOfMemoryType;
	private static readonly Type s_threadAbortType;
	private static readonly Type s_nullReferenceType;
	private static readonly Type s_accessViolationType;
	private static readonly Type s_securityType;
	internal static readonly bool IsWindowsNT;
	internal static readonly bool IsPlatformNT5;
	internal static readonly string StrEmpty;
	internal static readonly string[] AzureSqlServerEndpoints;
	internal static readonly IntPtr PtrZero;
	internal static readonly int PtrSize;


	private static void TraceException(string trace, Exception e) { }

	internal static void TraceExceptionAsReturnValue(Exception e) { }

	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	internal static ArgumentException Argument(string error) { }

	internal static ArgumentException Argument(string error, string parameter) { }

	internal static ArgumentNullException ArgumentNull(string parameter) { }

	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	internal static InvalidOperationException InvalidOperation(string error) { }

	internal static NotSupportedException NotSupported() { }

	internal static NotSupportedException NotSupported(string error) { }

	internal static bool IsCatchableExceptionType(Exception e) { }

	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	internal static string BuildQuotedString(string quotePrefix, string quoteSuffix, string unQuotedString) { }

	internal static bool CompareInsensitiveInvariant(string strvalue, string strconst) { }

	internal static bool IsNull(object value) { }

	internal static Exception InvalidSeekOrigin(string parameterName) { }

	internal static void TraceExceptionForCapture(Exception e) { }

	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	internal static ArgumentOutOfRangeException InvalidConflictOptions(ConflictOption value) { }

	internal static ArgumentOutOfRangeException InvalidMissingMappingAction(MissingMappingAction value) { }

	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	internal static ArgumentOutOfRangeException InvalidStatementType(StatementType value) { }

	internal static ArgumentOutOfRangeException InvalidUpdateStatus(UpdateStatus value) { }

	internal static Exception WrongType(Type got, Type expected) { }

	private static InvalidOperationException DataMapping(string error) { }

	internal static InvalidOperationException ColumnSchemaExpression(string srcColumn, string cacheColumn) { }

	internal static InvalidOperationException ColumnSchemaMismatch(string srcColumn, Type srcType, DataColumn column) { }

	internal static InvalidOperationException ColumnSchemaMissing(string cacheColumn, string tableName, string srcColumn) { }

	internal static InvalidOperationException MissingColumnMapping(string srcColumn) { }

	internal static Exception InvalidSourceColumn(string parameter) { }

	internal static InvalidOperationException DynamicSQLJoinUnsupported() { }

	internal static InvalidOperationException DynamicSQLNoTableInfo() { }

	internal static InvalidOperationException DynamicSQLNoKeyInfoDelete() { }

	internal static InvalidOperationException DynamicSQLNoKeyInfoUpdate() { }

	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionDelete() { }

	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionUpdate() { }

	internal static InvalidOperationException DynamicSQLNestedQuote(string name, string quote) { }

	internal static InvalidOperationException NoQuoteChange() { }

	internal static InvalidOperationException MissingSourceCommand() { }

	internal static InvalidOperationException MissingSourceCommandConnection() { }

	internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray) { }

	private static int GenerateUniqueName(Dictionary<string, int> hash, ref string columnName, int index, int uniqueIndex) { }

	internal static int SrcCompare(string strA, string strB) { }

	private static void .cctor() { }

}

