internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 591
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D1EF0 Offset: 0x18D12F0 VA: 0x1818D1EF0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D1CE0 Offset: 0x18D10E0 VA: 0x1818D1CE0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D1FB0 Offset: 0x18D13B0 VA: 0x1818D1FB0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D1EF0 Offset: 0x18D12F0 VA: 0x1818D1EF0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D1FA0 Offset: 0x18D13A0 VA: 0x1818D1FA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D1A30 Offset: 0x18D0E30 VA: 0x1818D1A30
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D1D70 Offset: 0x18D1170 VA: 0x1818D1D70 Slot: 35
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D1F90 Offset: 0x18D1390 VA: 0x1818D1F90
	internal string SerializationToString() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

