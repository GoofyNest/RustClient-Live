internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 4267
{	internal readonly int _op; // 0x18


	internal void .ctor(int op) { }

	internal override void Bind(DataTable table, List<DataColumn> list) { }

	internal override object Eval() { }

	internal override object Eval(DataRow row, DataRowVersion version) { }

	internal override object Eval(int[] recordNos) { }

	internal override bool IsConstant() { }

	internal override bool IsTableConstant() { }

	internal override bool HasLocalAggregate() { }

	internal override bool HasRemoteAggregate() { }

	internal override ExpressionNode Optimize() { }

}

