internal static class ADP // TypeDefIndex: 4363
{	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly bool IsWindowsNT; // 0x30
	internal static readonly bool IsPlatformNT5; // 0x31
	internal static readonly string StrEmpty; // 0x38
	internal static readonly string[] AzureSqlServerEndpoints; // 0x40
	internal static readonly IntPtr PtrZero; // 0x48
	internal static readonly int PtrSize; // 0x50

	// Methods

	// RVA: 0x1260D40 Offset: 0x1260140 VA: 0x181260D40
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1260AD0 Offset: 0x125FED0 VA: 0x181260AD0
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1260C70 Offset: 0x1260070 VA: 0x181260C70
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x125ED90 Offset: 0x125E190 VA: 0x18125ED90
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x125ED00 Offset: 0x125E100 VA: 0x18125ED00
	internal static ArgumentException Argument(string error, string parameter) { }

	// RVA: 0x125EB70 Offset: 0x125DF70 VA: 0x18125EB70
	internal static ArgumentNullException ArgumentNull(string parameter) { }

	// RVA: 0x125EC80 Offset: 0x125E080 VA: 0x18125EC80
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x125EBF0 Offset: 0x125DFF0 VA: 0x18125EBF0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x125FED0 Offset: 0x125F2D0 VA: 0x18125FED0
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1260A40 Offset: 0x125FE40 VA: 0x181260A40
	internal static NotSupportedException NotSupported() { }

	// RVA: 0x12609C0 Offset: 0x125FDC0 VA: 0x1812609C0
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1260230 Offset: 0x125F630 VA: 0x181260230
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x12604E0 Offset: 0x125F8E0 VA: 0x1812604E0
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x125FCC0 Offset: 0x125F0C0 VA: 0x18125FCC0
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x125EE10 Offset: 0x125E210 VA: 0x18125EE10
	internal static string BuildQuotedString(string quotePrefix, string quoteSuffix, string unQuotedString) { }

	// RVA: 0x125F730 Offset: 0x125EB30 VA: 0x18125F730
	internal static bool CompareInsensitiveInvariant(string strvalue, string strconst) { }

	// RVA: 0x1260730 Offset: 0x125FB30 VA: 0x181260730
	internal static bool IsNull(object value) { }

	// RVA: 0x125FFE0 Offset: 0x125F3E0 VA: 0x18125FFE0
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1260BA0 Offset: 0x125FFA0 VA: 0x181260BA0
	internal static void TraceExceptionForCapture(Exception e) { }

	// RVA: 0x125FBA0 Offset: 0x125EFA0 VA: 0x18125FBA0
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x125FC30 Offset: 0x125F030 VA: 0x18125FC30
	internal static ArgumentOutOfRangeException InvalidConflictOptions(ConflictOption value) { }

	// RVA: 0x125FDB0 Offset: 0x125F1B0 VA: 0x18125FDB0
	internal static ArgumentOutOfRangeException InvalidMissingMappingAction(MissingMappingAction value) { }

	// RVA: 0x125FE40 Offset: 0x125F240 VA: 0x18125FE40
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x125FF50 Offset: 0x125F350 VA: 0x18125FF50
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1260110 Offset: 0x125F510 VA: 0x181260110
	internal static ArgumentOutOfRangeException InvalidStatementType(StatementType value) { }

	// RVA: 0x12601A0 Offset: 0x125F5A0 VA: 0x1812601A0
	internal static ArgumentOutOfRangeException InvalidUpdateStatus(UpdateStatus value) { }

	// RVA: 0x1260DD0 Offset: 0x12601D0 VA: 0x181260DD0
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x125F7E0 Offset: 0x125EBE0 VA: 0x18125F7E0
	private static InvalidOperationException DataMapping(string error) { }

	// RVA: 0x125F2A0 Offset: 0x125E6A0 VA: 0x18125F2A0
	internal static InvalidOperationException ColumnSchemaExpression(string srcColumn, string cacheColumn) { }

	// RVA: 0x125F360 Offset: 0x125E760 VA: 0x18125F360
	internal static InvalidOperationException ColumnSchemaMismatch(string srcColumn, Type srcType, DataColumn column) { }

	// RVA: 0x125F640 Offset: 0x125EA40 VA: 0x18125F640
	internal static InvalidOperationException ColumnSchemaMissing(string cacheColumn, string tableName, string srcColumn) { }

	// RVA: 0x12607D0 Offset: 0x125FBD0 VA: 0x1812607D0
	internal static InvalidOperationException MissingColumnMapping(string srcColumn) { }

	// RVA: 0x1260040 Offset: 0x125F440 VA: 0x181260040
	internal static Exception InvalidSourceColumn(string parameter) { }

	// RVA: 0x125F840 Offset: 0x125EC40 VA: 0x18125F840
	internal static InvalidOperationException DynamicSQLJoinUnsupported() { }

	// RVA: 0x125FA50 Offset: 0x125EE50 VA: 0x18125FA50
	internal static InvalidOperationException DynamicSQLNoTableInfo() { }

	// RVA: 0x125F910 Offset: 0x125ED10 VA: 0x18125F910
	internal static InvalidOperationException DynamicSQLNoKeyInfoDelete() { }

	// RVA: 0x125FA00 Offset: 0x125EE00 VA: 0x18125FA00
	internal static InvalidOperationException DynamicSQLNoKeyInfoUpdate() { }

	// RVA: 0x125F960 Offset: 0x125ED60 VA: 0x18125F960
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionDelete() { }

	// RVA: 0x125F9B0 Offset: 0x125EDB0 VA: 0x18125F9B0
	internal static InvalidOperationException DynamicSQLNoKeyInfoRowVersionUpdate() { }

	// RVA: 0x125F890 Offset: 0x125EC90 VA: 0x18125F890
	internal static InvalidOperationException DynamicSQLNestedQuote(string name, string quote) { }

	// RVA: 0x1260970 Offset: 0x125FD70 VA: 0x181260970
	internal static InvalidOperationException NoQuoteChange() { }

	// RVA: 0x1260920 Offset: 0x125FD20 VA: 0x181260920
	internal static InvalidOperationException MissingSourceCommand() { }

	// RVA: 0x12608D0 Offset: 0x125FCD0 VA: 0x1812608D0
	internal static InvalidOperationException MissingSourceCommandConnection() { }

	// RVA: 0x125EF20 Offset: 0x125E320 VA: 0x18125EF20
	internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray) { }

	// RVA: 0x125FAA0 Offset: 0x125EEA0 VA: 0x18125FAA0
	private static int GenerateUniqueName(Dictionary<string, int> hash, ref string columnName, int index, int uniqueIndex) { }

	// RVA: 0x1260AB0 Offset: 0x125FEB0 VA: 0x181260AB0
	internal static int SrcCompare(string strA, string strB) { }

	// RVA: 0x1260EF0 Offset: 0x12602F0 VA: 0x181260EF0
	private static void .cctor() { }

}

