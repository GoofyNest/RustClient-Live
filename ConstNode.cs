internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 4246
{	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x1220DF0 Offset: 0x12201F0 VA: 0x181220DF0
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x1220AF0 Offset: 0x121FEF0 VA: 0x181220AF0
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	internal override object Eval() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x12205D0 Offset: 0x121F9D0 VA: 0x1812205D0
	private object SmallestDecimal(object constant) { }

	// RVA: 0x1220870 Offset: 0x121FC70 VA: 0x181220870
	private object SmallestNumeric(object constant) { }

}

