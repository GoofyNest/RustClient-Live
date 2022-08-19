public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 542
{	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x18C7DC0 Offset: 0x18C71C0 VA: 0x1818C7DC0
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18C7EB0 Offset: 0x18C72B0 VA: 0x1818C7EB0
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18C6790 Offset: 0x18C5B90 VA: 0x1818C6790 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18C7D70 Offset: 0x18C7170 VA: 0x1818C7D70 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract MethodInfo GetBaseDefinition();

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x18C7C20 Offset: 0x18C7020 VA: 0x1818C7C20 Slot: 24
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	// RVA: 0x18C7C90 Offset: 0x18C7090 VA: 0x1818C7C90 Slot: 42
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18C7D00 Offset: 0x18C7100 VA: 0x1818C7D00 Slot: 43
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x18C7BB0 Offset: 0x18C6FB0 VA: 0x1818C7BB0 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 45
	internal virtual MethodInfo GetBaseMethod() { }

}

