internal abstract class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 575
{
internal BindingFlags BindingFlags { get; }
public override Module Module { get; }
private RuntimeType ReflectedTypeInternal { get; }


internal BindingFlags get_BindingFlags() { }

public override Module get_Module() { }

internal RuntimeType GetDeclaringTypeInternal() { }

private RuntimeType get_ReflectedTypeInternal() { }

internal RuntimeModule GetRuntimeModule() { }

public void GetObjectData(SerializationInfo info, StreamingContext context) { }

protected void .ctor() { }

}

