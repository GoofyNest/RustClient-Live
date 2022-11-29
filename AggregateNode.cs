internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 4247
{
	private readonly AggregateType _type; 
	private readonly Aggregate _aggregate; 
	private readonly bool _local; 
	private readonly string _relationName; 
	private readonly string _columnName; 
	private DataTable _childTable; 
	private DataColumn _column; 
	private DataRelation _relation; 


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

