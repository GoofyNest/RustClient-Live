internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 583
{	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x18D09D0 Offset: 0x18CFDD0 VA: 0x1818D09D0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D09D0 Offset: 0x18CFDD0 VA: 0x1818D09D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D0C10 Offset: 0x18D0010 VA: 0x1818D0C10
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D0840 Offset: 0x18CFC40 VA: 0x1818D0840 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D0BF0 Offset: 0x18CFFF0 VA: 0x1818D0BF0
	internal string SerializationToString() { }

	// RVA: 0x18D0A70 Offset: 0x18CFE70 VA: 0x1818D0A70
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C9120 Offset: 0x18C8520 VA: 0x1818C9120
	protected void .ctor() { }

}

