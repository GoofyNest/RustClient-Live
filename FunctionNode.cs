internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 4259
{
	internal readonly string _name; 
	internal readonly int _info; 
	internal int _argumentCount; 
	internal ExpressionNode[] _arguments; 
	private static readonly Function[] s_funcs; 

	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }


	internal void .ctor(DataTable table, string name) { }

	internal void AddArgument(ExpressionNode argument) { }

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

	private Type GetDataType(ExpressionNode node) { }

	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	internal FunctionId get_Aggregate() { }

	internal bool get_IsAggregate() { }

	internal void Check() { }

	private static void .cctor() { }

}

