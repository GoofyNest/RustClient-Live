public struct Hand : IEquatable<Hand> // TypeDefIndex: 4151
{
	private ulong m_DeviceId;
	private uint m_FeatureIndex;

	internal ulong deviceId { get; }
	internal uint featureIndex { get; }


	internal ulong get_deviceId() { }

	internal uint get_featureIndex() { }

	public override bool Equals(object obj) { }

	public bool Equals(Hand other) { }

	public override int GetHashCode() { }

}

