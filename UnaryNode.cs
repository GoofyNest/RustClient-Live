internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 4266
{	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xCC8740 Offset: 0xCC7B40 VA: 0x180CC8740
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xCC7800 Offset: 0xCC6C00 VA: 0x180CC7800 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCC8540 Offset: 0xCC7940 VA: 0x180CC8540 Slot: 6
	internal override object Eval() { }

	// RVA: 0xCC84F0 Offset: 0xCC78F0 VA: 0x180CC84F0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xCC8560 Offset: 0xCC7960 VA: 0x180CC8560 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xCC7890 Offset: 0xCC6C90 VA: 0x180CC7890
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xCC85F0 Offset: 0xCC79F0 VA: 0x180CC85F0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0xCC8620 Offset: 0xCC7A20 VA: 0x180CC8620 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0xCC8590 Offset: 0xCC7990 VA: 0x180CC8590 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0xCC85C0 Offset: 0xCC79C0 VA: 0x180CC85C0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xCC7860 Offset: 0xCC6C60 VA: 0x180CC7860 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xCC8650 Offset: 0xCC7A50 VA: 0x180CC8650 Slot: 13
	internal override ExpressionNode Optimize() { }

}

