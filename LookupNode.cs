internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 4263
{
	private readonly string _relationName; 
	private readonly string _columnName; 
	private DataColumn _column; 
	private DataRelation _relation; 


internal void .ctor(DataTable table, string columnName, string relationName) { }

internal override void Bind(DataTable table, List<DataColumn> list) { }

internal override object Eval() { }

internal override object Eval(DataRow row, DataRowVersion version) { }

internal override object Eval(int[] recordNos) { }

internal override bool IsConstant() { }

internal override bool IsTableConstant() { }

internal override bool HasLocalAggregate() { }

internal override bool HasRemoteAggregate() { }

internal override bool DependsOn(DataColumn column) { }

internal override ExpressionNode Optimize() { }

}

