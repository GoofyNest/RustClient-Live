internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 4263
{	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0xEA0FD0 Offset: 0xEA03D0 VA: 0x180EA0FD0
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xEA0B90 Offset: 0xE9FF90 VA: 0x180EA0B90 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xEA0E20 Offset: 0xEA0220 VA: 0x180EA0E20 Slot: 6
	internal override object Eval() { }

	// RVA: 0xEA0EB0 Offset: 0xEA02B0 VA: 0x180EA0EB0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xEA0E60 Offset: 0xEA0260 VA: 0x180EA0E60 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xEA0E10 Offset: 0xEA0210 VA: 0x180EA0E10 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 13
	internal override ExpressionNode Optimize() { }

}

