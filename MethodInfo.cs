public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 542
{	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }


	protected void .ctor() { }

	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override MemberTypes get_MemberType() { }

	public virtual Type get_ReturnType() { }

	public abstract MethodInfo GetBaseDefinition();

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
	public virtual MethodInfo GetGenericMethodDefinition() { }

	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	public virtual Delegate CreateDelegate(Type delegateType) { }

	internal virtual MethodInfo GetBaseMethod() { }

}

