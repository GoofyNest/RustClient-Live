internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 4267
{	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x1ADBDC0 Offset: 0x1ADB1C0 VA: 0x181ADBDC0
	internal void .ctor(int op) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1ADBD20 Offset: 0x1ADB120 VA: 0x181ADBD20 Slot: 6
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

}

