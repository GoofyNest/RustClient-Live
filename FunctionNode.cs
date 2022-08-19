internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 4259
{	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x13E8230 Offset: 0x13E7630 VA: 0x1813E8230
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x13E3800 Offset: 0x13E2C00 VA: 0x1813E3800
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x13E3A20 Offset: 0x13E2E20 VA: 0x1813E3A20 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCC8540 Offset: 0xCC7940 VA: 0x180CC8540 Slot: 6
	internal override object Eval() { }

	// RVA: 0x13E6180 Offset: 0x13E5580 VA: 0x1813E6180 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x13E6130 Offset: 0x13E5530 VA: 0x1813E6130 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x13E7210 Offset: 0x13E6610 VA: 0x1813E7210 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x13E7290 Offset: 0x13E6690 VA: 0x1813E7290 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x13E7110 Offset: 0x13E6510 VA: 0x1813E7110 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x13E7190 Offset: 0x13E6590 VA: 0x1813E7190 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x13E4030 Offset: 0x13E3430 VA: 0x1813E4030 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x13E7310 Offset: 0x13E6710 VA: 0x1813E7310 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x13E6E70 Offset: 0x13E6270 VA: 0x1813E6E70
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x13E40C0 Offset: 0x13E34C0 VA: 0x1813E40C0
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x13E83A0 Offset: 0x13E77A0 VA: 0x1813E83A0
	internal FunctionId get_Aggregate() { }

	// RVA: 0x13E8450 Offset: 0x13E7850 VA: 0x1813E8450
	internal bool get_IsAggregate() { }

	// RVA: 0x13E3D80 Offset: 0x13E3180 VA: 0x1813E3D80
	internal void Check() { }

	// RVA: 0x13E7510 Offset: 0x13E6910 VA: 0x1813E7510
	private static void .cctor() { }

}

