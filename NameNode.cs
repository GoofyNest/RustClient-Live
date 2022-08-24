internal sealed class NameNode : ExpressionNode // TypeDefIndex: 4264
{
	internal string _name; 
	internal bool _found; 
	internal DataColumn _column; 

	internal override bool IsSqlColumn { get; }


	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	internal void .ctor(DataTable table, string name) { }

	internal override bool get_IsSqlColumn() { }

	internal override void Bind(DataTable table, List<DataColumn> list) { }

	internal override object Eval() { }

	internal override object Eval(DataRow row, DataRowVersion version) { }

	internal override object Eval(int[] records) { }

	internal override bool IsConstant() { }

	internal override bool IsTableConstant() { }

	internal override bool HasLocalAggregate() { }

	internal override bool HasRemoteAggregate() { }

	internal override bool DependsOn(DataColumn column) { }

	internal override ExpressionNode Optimize() { }

	internal static string ParseName(char[] text, int start, int pos) { }

}

