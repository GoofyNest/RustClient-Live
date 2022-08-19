internal sealed class NameNode : ExpressionNode // TypeDefIndex: 4264
{	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0xEA4870 Offset: 0xEA3C70 VA: 0x180EA4870
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0xEA4830 Offset: 0xEA3C30 VA: 0x180EA4830
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xEA48C0 Offset: 0xEA3CC0 VA: 0x180EA48C0 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xEA40D0 Offset: 0xEA34D0 VA: 0x180EA40D0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xEA4360 Offset: 0xEA3760 VA: 0x180EA4360 Slot: 6
	internal override object Eval() { }

	// RVA: 0xEA43A0 Offset: 0xEA37A0 VA: 0x180EA43A0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xEA4310 Offset: 0xEA3710 VA: 0x180EA4310 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xEA4540 Offset: 0xEA3940 VA: 0x180EA4540 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xEA44A0 Offset: 0xEA38A0 VA: 0x180EA44A0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xEA44F0 Offset: 0xEA38F0 VA: 0x180EA44F0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xEA42A0 Offset: 0xEA36A0 VA: 0x180EA42A0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0xEA4590 Offset: 0xEA3990 VA: 0x180EA4590
	internal static string ParseName(char[] text, int start, int pos) { }

}

