public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 303
{
	private static readonly StringComparer _invariantCulture; 
	private static readonly StringComparer _invariantCultureIgnoreCase; 
	private static readonly StringComparer _ordinal; 
	private static readonly StringComparer _ordinalIgnoreCase; 

public static StringComparer InvariantCultureIgnoreCase { get; }
public static StringComparer CurrentCultureIgnoreCase { get; }
public static StringComparer Ordinal { get; }
public static StringComparer OrdinalIgnoreCase { get; }


public static StringComparer get_InvariantCultureIgnoreCase() { }

public static StringComparer get_CurrentCultureIgnoreCase() { }

public static StringComparer get_Ordinal() { }

public static StringComparer get_OrdinalIgnoreCase() { }

public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

public int Compare(object x, object y) { }

public bool Equals(object x, object y) { }

public int GetHashCode(object obj) { }

public abstract int Compare(string x, string y);

public abstract bool Equals(string x, string y);

public abstract int GetHashCode(string obj);

protected void .ctor() { }

private static void .cctor() { }

}

