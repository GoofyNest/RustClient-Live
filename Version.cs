public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 334
{
	private int _Major; 
	private int _Minor; 
	private int _Build; 
	private int _Revision; 
	private static readonly char[] SeparatorsArray; 
	private const int ZERO_CHAR_VALUE = 48;

	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }


	public void .ctor(int major, int minor, int build, int revision) { }

	public void .ctor(int major, int minor, int build) { }

	public void .ctor(int major, int minor) { }

	public void .ctor(string version) { }

	public void .ctor() { }

	public int get_Major() { }

	public int get_Minor() { }

	public int get_Build() { }

	public int get_Revision() { }

	public object Clone() { }

	public int CompareTo(object version) { }

	public int CompareTo(Version value) { }

	public override bool Equals(object obj) { }

	public bool Equals(Version obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(int fieldCount) { }

	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	public static Version Parse(string input) { }

	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	public static bool op_Equality(Version v1, Version v2) { }

	public static bool op_Inequality(Version v1, Version v2) { }

	public static bool op_LessThan(Version v1, Version v2) { }

	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	private static void .cctor() { }

}

internal enum Version.ParseFailureKind // TypeDefIndex: 335
{
	public int value__; 
	public const Version.ParseFailureKind ArgumentNullException = 0;
	public const Version.ParseFailureKind ArgumentException = 1;
	public const Version.ParseFailureKind ArgumentOutOfRangeException = 2;
	public const Version.ParseFailureKind FormatException = 3;

}

internal struct Version.VersionResult // TypeDefIndex: 336
{
	internal Version m_parsedVersion; 
	internal Version.ParseFailureKind m_failure; 
	internal string m_exceptionArgument; 
	internal string m_argumentName; 
	internal bool m_canThrow; 


	internal void Init(string argumentName, bool canThrow) { }

	internal void SetFailure(Version.ParseFailureKind failure) { }

	internal void SetFailure(Version.ParseFailureKind failure, string argument) { }

	internal Exception GetVersionParseException() { }

}

public static class Version // TypeDefIndex: 13290
{
	public const int Current = 1510;

}

