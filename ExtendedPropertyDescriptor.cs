internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2707
{

internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor 
	private readonly ReflectPropertyDescriptor extenderInfo; 
	private readonly IExtenderProvider provider; 

public override Type ComponentType { get; }
public override bool IsReadOnly { get; }
public override Type PropertyType { get; }
public override string DisplayName { get; }


public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

public override Type get_ComponentType() { }

public override bool get_IsReadOnly() { }

public override Type get_PropertyType() { }

public override string get_DisplayName() { }

public override object GetValue(object comp) { }

public override void SetValue(object component, object value) { }

public override bool ShouldSerializeValue(object comp) { }

}

