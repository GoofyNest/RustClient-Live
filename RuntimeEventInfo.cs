internal abstract class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 575
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D0E70 Offset: 0x18D0270 VA: 0x1818D0E70 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D0CA0 Offset: 0x18D00A0 VA: 0x1818D0CA0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D0F10 Offset: 0x18D0310 VA: 0x1818D0F10
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D0E70 Offset: 0x18D0270 VA: 0x1818D0E70
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D0D30 Offset: 0x18D0130 VA: 0x1818D0D30 Slot: 21
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

