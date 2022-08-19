public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 2708
{	// Fields
	private PropertyDescriptor extenderProperty; // 0x10
	private IExtenderProvider provider; // 0x18
	private Type receiverType; // 0x20

	// Properties
	public IExtenderProvider Provider { get; }
	public Type ReceiverType { get; }

	// Methods

	// RVA: 0x15A0540 Offset: 0x159F940 VA: 0x1815A0540
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public IExtenderProvider get_Provider() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Type get_ReceiverType() { }

	// RVA: 0x15A05F0 Offset: 0x159F9F0 VA: 0x1815A05F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159ADA0 Offset: 0x159A1A0 VA: 0x18159ADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15A06E0 Offset: 0x159FAE0 VA: 0x1815A06E0 Slot: 6
	public override bool IsDefaultAttribute() { }

}

