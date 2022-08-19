public abstract class ConstructorInfo : MethodBase, _ConstructorInfo // TypeDefIndex: 559
{	// Fields
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public static readonly string ConstructorName; // 0x0
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerStepThroughAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[DebuggerHiddenAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x18C1550 Offset: 0x18C0950 VA: 0x1818C1550
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C11E0 Offset: 0x18C05E0 VA: 0x1818C11E0
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x18C1230 Offset: 0x18C0630 VA: 0x1818C1230
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x18C1600 Offset: 0x18C0A00 VA: 0x1818C1600
	private static void .cctor() { }

}

