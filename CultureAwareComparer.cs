internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{
	private CompareInfo _compareInfo; 
	private bool _ignoreCase; 
	[OptionalFieldAttribute] 
	private CompareOptions _options; 


	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	public override int Compare(string x, string y) { }

	public override bool Equals(string x, string y) { }

	public override int GetHashCode(string obj) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

