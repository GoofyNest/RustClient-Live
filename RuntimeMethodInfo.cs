internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 581
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D17A0 Offset: 0x18D0BA0 VA: 0x1818D17A0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D19A0 Offset: 0x18D0DA0 VA: 0x1818D19A0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D12F0 Offset: 0x18D06F0 VA: 0x1818D12F0 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D12D0 Offset: 0x18D06D0 VA: 0x1818D12D0 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x18D1910 Offset: 0x18D0D10 VA: 0x1818D1910 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D17A0 Offset: 0x18D0BA0 VA: 0x1818D17A0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D15D0 Offset: 0x18D09D0 VA: 0x1818D15D0 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D1870 Offset: 0x18D0C70 VA: 0x1818D1870
	internal string SerializationToString() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

