internal abstract class ExpressionNode // TypeDefIndex: 4248
{	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	protected void .ctor(DataTable table) { }

	// RVA: 0x13DCA40 Offset: 0x13DBE40 VA: 0x1813DCA40
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	protected DataTable get_table() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x13DC910 Offset: 0x13DBD10 VA: 0x1813DC910
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x13DC8F0 Offset: 0x13DBCF0 VA: 0x1813DC8F0
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x13DC9E0 Offset: 0x13DBDE0 VA: 0x1813DC9E0
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x13DC9A0 Offset: 0x13DBDA0 VA: 0x1813DC9A0
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x13DCA20 Offset: 0x13DBE20 VA: 0x1813DCA20
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x13DCA00 Offset: 0x13DBE00 VA: 0x1813DCA00
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x13DC970 Offset: 0x13DBD70 VA: 0x1813DC970
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x13DC930 Offset: 0x13DBD30 VA: 0x1813DC930
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x13DC8D0 Offset: 0x13DBCD0 VA: 0x1813DC8D0
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x13DC8B0 Offset: 0x13DBCB0 VA: 0x1813DC8B0
	internal static bool IsFloatSql(StorageType type) { }

}

