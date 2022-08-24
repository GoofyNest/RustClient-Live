public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 2708
{
	private PropertyDescriptor extenderProperty; 
	private IExtenderProvider provider; 
	private Type receiverType; 

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

