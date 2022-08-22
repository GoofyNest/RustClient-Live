internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1386
{	private IComparer _comparer; // 0x10
	private IHashCodeProvider _hcp; // 0x18

	internal IComparer Comparer { get; }
	internal IHashCodeProvider HashCodeProvider { get; }


	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	public int Compare(object a, object b) { }

	public bool Equals(object a, object b) { }

	public int GetHashCode(object obj) { }

	internal IComparer get_Comparer() { }

	internal IHashCodeProvider get_HashCodeProvider() { }

}

internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 3105
{	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }


	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	public bool Equals(object a, object b) { }

	public int GetHashCode(object obj) { }

	public IComparer get_Comparer() { }

	public IHashCodeProvider get_HashCodeProvider() { }

	public static IComparer get_DefaultComparer() { }

	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}

