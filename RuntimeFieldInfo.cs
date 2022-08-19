internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 577
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D11A0 Offset: 0x18D05A0 VA: 0x1818D11A0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D0FA0 Offset: 0x18D03A0 VA: 0x1818D0FA0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D1240 Offset: 0x18D0640 VA: 0x1818D1240
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D11A0 Offset: 0x18D05A0 VA: 0x1818D11A0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D1030 Offset: 0x18D0430 VA: 0x1818D1030 Slot: 32
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

