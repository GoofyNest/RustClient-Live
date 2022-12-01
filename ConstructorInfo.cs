public abstract class ConstructorInfo : MethodBase, _ConstructorInfo // TypeDefIndex: 559
{
	[ComVisibleAttribute]
	public static readonly string ConstructorName;
	[ComVisibleAttribute]
	public static readonly string TypeConstructorName;

	[ComVisibleAttribute]
	public override MemberTypes MemberType { get; }


	protected void .ctor() { }

	public override MemberTypes get_MemberType() { }

	[DebuggerHiddenAttribute]
	[DebuggerStepThroughAttribute]
	public object Invoke(object[] parameters) { }

	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	private static void .cctor() { }

}

