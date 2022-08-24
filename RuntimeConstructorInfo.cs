internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 583
{
public override Module Module { get; }
internal BindingFlags BindingFlags { get; }
private RuntimeType ReflectedTypeInternal { get; }


public override Module get_Module() { }

internal RuntimeModule GetRuntimeModule() { }

internal BindingFlags get_BindingFlags() { }

private RuntimeType get_ReflectedTypeInternal() { }

public void GetObjectData(SerializationInfo info, StreamingContext context) { }

internal string SerializationToString() { }

internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

protected void .ctor() { }

}

