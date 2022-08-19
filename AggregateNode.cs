internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 4242
{	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x1261D60 Offset: 0x1261160 VA: 0x181261D60
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x1261C10 Offset: 0x1261010 VA: 0x181261C10
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1261440 Offset: 0x1260840 VA: 0x181261440 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x12612E0 Offset: 0x12606E0 VA: 0x1812612E0
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0xCC8540 Offset: 0xCC7940 VA: 0x180CC8540 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1261840 Offset: 0x1260C40 VA: 0x181261840 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1261B50 Offset: 0x1260F50 VA: 0x181261B50 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1261C00 Offset: 0x1261000 VA: 0x181261C00 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x12617D0 Offset: 0x1260BD0 VA: 0x1812617D0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 13
	internal override ExpressionNode Optimize() { }

}

