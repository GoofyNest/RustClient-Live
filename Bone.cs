public struct Bone : IEquatable<Bone> // TypeDefIndex: 4148
{
	private ulong m_DeviceId; 
	private uint m_FeatureIndex; 

internal ulong deviceId { get; }
internal uint featureIndex { get; }


internal ulong get_deviceId() { }

internal uint get_featureIndex() { }

public override bool Equals(object obj) { }

public bool Equals(Bone other) { }

public override int GetHashCode() { }

}

