internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 4249
{
	internal readonly object _val; 


	internal void .ctor(DataTable table, ValueType type, object constant) { }

	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	internal override void Bind(DataTable table, List<DataColumn> list) { }

	internal override object Eval() { }

	internal override object Eval(DataRow row, DataRowVersion version) { }

	internal override object Eval(int[] recordNos) { }

	internal override bool IsConstant() { }

	internal override bool IsTableConstant() { }

	internal override bool HasLocalAggregate() { }

	internal override bool HasRemoteAggregate() { }

	internal override ExpressionNode Optimize() { }

	private object SmallestDecimal(object constant) { }

	private object SmallestNumeric(object constant) { }

}

