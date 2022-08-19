public struct TypedReference // TypeDefIndex: 323
{	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x213F6A0 Offset: 0x213EAA0 VA: 0x18213F6A0
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x213F680 Offset: 0x213EA80 VA: 0x18213F680
	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	// RVA: 0x232830 Offset: 0x231C30 VA: 0x180232830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232820 Offset: 0x231C20 VA: 0x180232820 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2328D0 Offset: 0x231CD0 VA: 0x1802328D0
	internal bool get_IsNull() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x213FBC0 Offset: 0x213EFC0 VA: 0x18213FBC0
	public static void SetTypedReference(TypedReference target, object value) { }

}

