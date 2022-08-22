internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 591
{	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }


	internal BindingFlags get_BindingFlags() { }

	public override Module get_Module() { }

	internal RuntimeType GetDeclaringTypeInternal() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	internal RuntimeModule GetRuntimeModule() { }

	public override string ToString() { }

	private string FormatNameAndSig(bool serialization) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal string SerializationToString() { }

	protected void .ctor() { }

}

