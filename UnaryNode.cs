internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 4266
{
	internal readonly int _op; 
	internal ExpressionNode _right; 


internal void .ctor(DataTable table, int op, ExpressionNode right) { }

internal override void Bind(DataTable table, List<DataColumn> list) { }

internal override object Eval() { }

internal override object Eval(DataRow row, DataRowVersion version) { }

internal override object Eval(int[] recordNos) { }

private object EvalUnaryOp(int op, object vl) { }

internal override bool IsConstant() { }

internal override bool IsTableConstant() { }

internal override bool HasLocalAggregate() { }

internal override bool HasRemoteAggregate() { }

internal override bool DependsOn(DataColumn column) { }

internal override ExpressionNode Optimize() { }

}

