internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 581
{	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }


	internal BindingFlags get_BindingFlags() { }

	public override Module get_Module() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	internal override string FormatNameAndSig(bool serialization) { }

	public override Delegate CreateDelegate(Type delegateType) { }

	public override string ToString() { }

	internal RuntimeModule GetRuntimeModule() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal string SerializationToString() { }

	protected void .ctor() { }

}

