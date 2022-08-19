internal sealed class LikeNode : BinaryNode // TypeDefIndex: 4245
{	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xEA0B80 Offset: 0xE9FF80 VA: 0x180EA0B80
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xEA0250 Offset: 0xE9F650 VA: 0x180EA0250 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xE9FED0 Offset: 0xE9F2D0 VA: 0x180E9FED0
	internal string AnalyzePattern(string pat) { }

}

