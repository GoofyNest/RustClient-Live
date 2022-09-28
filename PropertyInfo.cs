public abstract class PropertyInfo : MemberInfo, _PropertyInfo // TypeDefIndex: 597
{
	public abstract PropertyAttributes Attributes { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }


	public abstract PropertyAttributes get_Attributes();

	public abstract bool get_CanRead();

	public abstract bool get_CanWrite();

	public override MemberTypes get_MemberType() { }

	public abstract Type get_PropertyType();

	protected void .ctor() { }

	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	public MethodInfo GetGetMethod() { }

	public abstract MethodInfo GetGetMethod(bool nonPublic);

	public abstract ParameterInfo[] GetIndexParameters();

	public MethodInfo GetSetMethod() { }

	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerStepThroughAttribute] 
	[DebuggerHiddenAttribute] 
	public virtual object GetValue(object obj, object[] index) { }

	[DebuggerHiddenAttribute] 
	[DebuggerStepThroughAttribute] 
	public object GetValue(object obj) { }

	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThroughAttribute] 
	[DebuggerHiddenAttribute] 
	public virtual void SetValue(object obj, object value, object[] index) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	public virtual Type[] GetOptionalCustomModifiers() { }

	public virtual Type[] GetRequiredCustomModifiers() { }

	private static NotImplementedException CreateNIE() { }

	public virtual object GetConstantValue() { }

	public virtual object GetRawConstantValue() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

}

