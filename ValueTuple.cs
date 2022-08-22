public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple> // TypeDefIndex: 125
{
	public override bool Equals(object obj) { }

	public bool Equals(ValueTuple other) { }

	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private int System.IComparable.CompareTo(object other) { }

	public int CompareTo(ValueTuple other) { }

	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	public override int GetHashCode() { }

	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	public override string ToString() { }

	internal static int CombineHashCodes(int h1, int h2) { }

	internal static int CombineHashCodes(int h1, int h2, int h3) { }

}

