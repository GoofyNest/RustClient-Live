public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 391
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	internal void .ctor(IntPtr val) { }

	// RVA: 0x1DF1B0 Offset: 0x1DE5B0 VA: 0x1801DF1B0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x1DF030 Offset: 0x1DE430 VA: 0x1801DF030
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public IntPtr get_Value() { }

	// RVA: 0x1DF010 Offset: 0x1DE410 VA: 0x1801DF010 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1DEF00 Offset: 0x1DE300 VA: 0x1801DEF00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1293BC0 Offset: 0x1292FC0 VA: 0x181293BC0
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1293C10 Offset: 0x1293010 VA: 0x181293C10
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x1293C10 Offset: 0x1293010 VA: 0x181293C10
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x1293C00 Offset: 0x1293000 VA: 0x181293C00
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x1293C00 Offset: 0x1293000 VA: 0x181293C00
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1293E20 Offset: 0x1293220 VA: 0x181293E20
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1293E60 Offset: 0x1293260 VA: 0x181293E60
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1293E80 Offset: 0x1293280 VA: 0x181293E80
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1293E90 Offset: 0x1293290 VA: 0x181293E90
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1293F60 Offset: 0x1293360 VA: 0x181293F60
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1293F90 Offset: 0x1293390 VA: 0x181293F90
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1293FA0 Offset: 0x12933A0 VA: 0x181293FA0
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1293E70 Offset: 0x1293270 VA: 0x181293E70
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x1293EA0 Offset: 0x12932A0 VA: 0x181293EA0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x1293EB0 Offset: 0x12932B0 VA: 0x181293EB0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1293FB0 Offset: 0x12933B0 VA: 0x181293FB0
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x1293F70 Offset: 0x1293370 VA: 0x181293F70
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x1293BA0 Offset: 0x1292FA0 VA: 0x181293BA0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x1293BB0 Offset: 0x1292FB0 VA: 0x181293BB0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1293BE0 Offset: 0x1292FE0 VA: 0x181293BE0
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1293C20 Offset: 0x1293020 VA: 0x181293C20
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1293F50 Offset: 0x1293350 VA: 0x181293F50
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1293BD0 Offset: 0x1292FD0 VA: 0x181293BD0
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1293B90 Offset: 0x1292F90 VA: 0x181293B90
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1294020 Offset: 0x1293420 VA: 0x181294020
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1293F40 Offset: 0x1293340 VA: 0x181293F40
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1293BF0 Offset: 0x1292FF0 VA: 0x181293BF0
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

}

