public struct CustomAttributeNamedArgument // TypeDefIndex: 563
{
	private CustomAttributeTypedArgument typedArgument;
	private MemberInfo memberInfo;

	public MemberInfo MemberInfo { get; }
	public CustomAttributeTypedArgument TypedValue { get; }


	public void .ctor(MemberInfo memberInfo, object value) { }

	public MemberInfo get_MemberInfo() { }

	public CustomAttributeTypedArgument get_TypedValue() { }

	public override string ToString() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

