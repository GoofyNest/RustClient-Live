public struct PublishedFileId : IEquatable<PublishedFileId>, IComparable<PublishedFileId> // TypeDefIndex: 5534
{
	public ulong Value; 


	public static PublishedFileId op_Implicit(ulong value) { }

	public static ulong op_Implicit(PublishedFileId value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(PublishedFileId p) { }

	public int CompareTo(PublishedFileId other) { }

}

