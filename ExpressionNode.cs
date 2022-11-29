internal abstract class ExpressionNode // TypeDefIndex: 4253
{
	private DataTable _table; 

	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }


	protected void .ctor(DataTable table) { }

	internal IFormatProvider get_FormatProvider() { }

	internal virtual bool get_IsSqlColumn() { }

	protected DataTable get_table() { }

	protected void BindTable(DataTable table) { }

	internal abstract void Bind(DataTable table, List<DataColumn> list);

	internal abstract object Eval();

	internal abstract object Eval(DataRow row, DataRowVersion version);

	internal abstract object Eval(int[] recordNos);

	internal abstract bool IsConstant();

	internal abstract bool IsTableConstant();

	internal abstract bool HasLocalAggregate();

	internal abstract bool HasRemoteAggregate();

	internal abstract ExpressionNode Optimize();

	internal virtual bool DependsOn(DataColumn column) { }

	internal static bool IsInteger(StorageType type) { }

	internal static bool IsIntegerSql(StorageType type) { }

	internal static bool IsSigned(StorageType type) { }

	internal static bool IsSignedSql(StorageType type) { }

	internal static bool IsUnsigned(StorageType type) { }

	internal static bool IsUnsignedSql(StorageType type) { }

	internal static bool IsNumeric(StorageType type) { }

	internal static bool IsNumericSql(StorageType type) { }

	internal static bool IsFloat(StorageType type) { }

	internal static bool IsFloatSql(StorageType type) { }

}

