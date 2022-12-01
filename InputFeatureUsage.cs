public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 4149
{
	internal string m_Name;
	[NativeNameAttribute]
	internal InputFeatureType m_InternalType;

	public string name { get; }
	internal InputFeatureType internalType { get; }


	public string get_name() { }

	internal InputFeatureType get_internalType() { }

	public override bool Equals(object obj) { }

	public bool Equals(InputFeatureUsage other) { }

	public override int GetHashCode() { }

}

