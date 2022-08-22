public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 2708
{	private PropertyDescriptor extenderProperty; // 0x10
	private IExtenderProvider provider; // 0x18
	private Type receiverType; // 0x20

	public IExtenderProvider Provider { get; }
	public Type ReceiverType { get; }


	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	public void .ctor() { }

	public IExtenderProvider get_Provider() { }

	public Type get_ReceiverType() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

}

