public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo // TypeDefIndex: 535
{	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual int MetadataToken { get; }
	public virtual Module Module { get; }


	protected void .ctor() { }

	public abstract MemberTypes get_MemberType();

	public abstract string get_Name();

	public abstract Type get_DeclaringType();

	public abstract Type get_ReflectedType();

	public abstract object[] GetCustomAttributes(bool inherit);

	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	public abstract bool IsDefined(Type attributeType, bool inherit);

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

