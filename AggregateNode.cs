internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 4242
{	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48


	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	internal override void Bind(DataTable table, List<DataColumn> list) { }

	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	internal override object Eval() { }

	internal override object Eval(DataRow row, DataRowVersion version) { }

	internal override object Eval(int[] records) { }

	internal override bool IsConstant() { }

	internal override bool IsTableConstant() { }

	internal override bool HasLocalAggregate() { }

	internal override bool HasRemoteAggregate() { }

	internal override bool DependsOn(DataColumn column) { }

	internal override ExpressionNode Optimize() { }

}

