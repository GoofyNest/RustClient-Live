public abstract class FieldInfo : MemberInfo, _FieldInfo // TypeDefIndex: 568
{	// Properties
	public abstract FieldAttributes Attributes { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }
	public abstract Type FieldType { get; }
	public override MemberTypes MemberType { get; }
	public bool IsLiteral { get; }
	public bool IsStatic { get; }
	public bool IsInitOnly { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsNotSerialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Type get_FieldType();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object GetValue(object obj);

	// RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18C4620 Offset: 0x18C3A20 VA: 0x1818C4620 Slot: 21
	public bool get_IsLiteral() { }

	// RVA: 0x18C46B0 Offset: 0x18C3AB0 VA: 0x1818C46B0 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x18C4600 Offset: 0x18C3A00 VA: 0x1818C4600 Slot: 23
	public bool get_IsInitOnly() { }

	// RVA: 0x18C4680 Offset: 0x18C3A80 VA: 0x1818C4680 Slot: 24
	public bool get_IsPublic() { }

	// RVA: 0x18C4660 Offset: 0x18C3A60 VA: 0x1818C4660 Slot: 25
	public bool get_IsPrivate() { }

	// RVA: 0x18C4640 Offset: 0x18C3A40 VA: 0x1818C4640 Slot: 26
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18C45D0 Offset: 0x18C39D0 VA: 0x1818C45D0 Slot: 28
	public void SetValue(object obj, object value) { }

	// RVA: 0x18C46D0 Offset: 0x18C3AD0 VA: 0x1818C46D0
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x18C40C0 Offset: 0x18C34C0 VA: 0x1818C40C0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18C4140 Offset: 0x18C3540 VA: 0x1818C4140
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x18C4200 Offset: 0x18C3600 VA: 0x1818C4200 Slot: 29
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x18C4560 Offset: 0x18C3960 VA: 0x1818C4560 Slot: 30
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17C4A20 Offset: 0x17C3E20 VA: 0x1817C4A20
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x18C4260 Offset: 0x18C3660 VA: 0x1818C4260
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18C4500 Offset: 0x18C3900 VA: 0x1818C4500 Slot: 31
	public virtual object GetRawConstantValue() { }

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C11E0 Offset: 0x18C05E0 VA: 0x1818C11E0
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x18C1230 Offset: 0x18C0630 VA: 0x1818C1230
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

}

