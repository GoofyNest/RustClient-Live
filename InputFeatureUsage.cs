public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 4144
{	// Fields
	internal string m_Name; // 0x0
	[NativeNameAttribute] // RVA: 0x95920 Offset: 0x94D20 VA: 0x180095920
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x1FB940 Offset: 0x1FAD40 VA: 0x1801FB940
	public string get_name() { }

	// RVA: 0x13AB80 Offset: 0x139F80 VA: 0x18013AB80
	internal InputFeatureType get_internalType() { }

	// RVA: 0x23E560 Offset: 0x23D960 VA: 0x18023E560 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E620 Offset: 0x23DA20 VA: 0x18023E620 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x23E670 Offset: 0x23DA70 VA: 0x18023E670 Slot: 2
	public override int GetHashCode() { }

}

