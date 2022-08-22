public struct Hand : IEquatable<Hand> // TypeDefIndex: 4146
{	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	internal ulong deviceId { get; }
	internal uint featureIndex { get; }


	internal ulong get_deviceId() { }

	internal uint get_featureIndex() { }

	public override bool Equals(object obj) { }

	public bool Equals(Hand other) { }

	public override int GetHashCode() { }

}

