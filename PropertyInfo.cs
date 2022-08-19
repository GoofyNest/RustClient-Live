public abstract class PropertyInfo : MemberInfo, _PropertyInfo // TypeDefIndex: 597
{	// Properties
	public abstract PropertyAttributes Attributes { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract PropertyAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_CanWrite();

	// RVA: 0xE84F40 Offset: 0xE84340 VA: 0x180E84F40 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Type get_PropertyType();

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	// RVA: 0x18CF470 Offset: 0x18CE870 VA: 0x1818CF470 Slot: 22
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: 0x18CF650 Offset: 0x18CEA50 VA: 0x1818CF650 Slot: 25
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18CC200 Offset: 0x18CB600 VA: 0x1818CC200 Slot: 27
	public virtual object GetValue(object obj, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18CF670 Offset: 0x18CEA70 VA: 0x1818CF670
	public object GetValue(object obj) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18CF6B0 Offset: 0x18CEAB0 VA: 0x1818CF6B0 Slot: 29
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x18CF490 Offset: 0x18CE890 VA: 0x1818CF490 Slot: 31
	public virtual Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18CF5F0 Offset: 0x18CE9F0 VA: 0x1818CF5F0 Slot: 32
	public virtual Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18CF3E0 Offset: 0x18CE7E0 VA: 0x1818CF3E0
	private static NotImplementedException CreateNIE() { }

	// RVA: 0x18CF430 Offset: 0x18CE830 VA: 0x1818CF430 Slot: 33
	public virtual object GetConstantValue() { }

	// RVA: 0x18CF5B0 Offset: 0x18CE9B0 VA: 0x1818CF5B0 Slot: 34
	public virtual object GetRawConstantValue() { }

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C11E0 Offset: 0x18C05E0 VA: 0x1818C11E0
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18C1230 Offset: 0x18C0630 VA: 0x1818C1230
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18CF6F0 Offset: 0x18CEAF0 VA: 0x1818CF6F0
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18CF4F0 Offset: 0x18CE8F0 VA: 0x1818CF4F0
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

}

