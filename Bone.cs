public struct Bone : IEquatable<Bone> // TypeDefIndex: 4148
{	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x1FB940 Offset: 0x1FAD40 VA: 0x1801FB940
	internal ulong get_deviceId() { }

	// RVA: 0x13AB80 Offset: 0x139F80 VA: 0x18013AB80
	internal uint get_featureIndex() { }

	// RVA: 0x23E140 Offset: 0x23D540 VA: 0x18023E140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E1F0 Offset: 0x23D5F0 VA: 0x18023E1F0 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x23E230 Offset: 0x23D630 VA: 0x18023E230 Slot: 2
	public override int GetHashCode() { }

}
