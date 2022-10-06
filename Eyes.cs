public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 4150
{
	private ulong m_DeviceId; 
	private uint m_FeatureIndex; 

	internal ulong deviceId { get; }
	internal uint featureIndex { get; }


	internal ulong get_deviceId() { }

	internal uint get_featureIndex() { }

	public override bool Equals(object obj) { }

	public bool Equals(Eyes other) { }

	public override int GetHashCode() { }

}

