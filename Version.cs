public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 334
{	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x2143FE0 Offset: 0x21433E0 VA: 0x182143FE0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x2143C40 Offset: 0x2143040 VA: 0x182143C40
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x2143EF0 Offset: 0x21432F0 VA: 0x182143EF0
	public void .ctor(int major, int minor) { }

	// RVA: 0x2143D90 Offset: 0x2143190 VA: 0x182143D90
	public void .ctor(string version) { }

	// RVA: 0x2143C10 Offset: 0x2143010 VA: 0x182143C10
	public void .ctor() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Major() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_Minor() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Build() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_Revision() { }

	// RVA: 0x21428D0 Offset: 0x2141CD0 VA: 0x1821428D0 Slot: 4
	public object Clone() { }

	// RVA: 0x2142950 Offset: 0x2141D50 VA: 0x182142950 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x2142AB0 Offset: 0x2141EB0 VA: 0x182142AB0 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x2142C50 Offset: 0x2142050 VA: 0x182142C50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2142BB0 Offset: 0x2141FB0 VA: 0x182142BB0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x2142D50 Offset: 0x2142150 VA: 0x182142D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21433A0 Offset: 0x21427A0 VA: 0x1821433A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2142E70 Offset: 0x2142270 VA: 0x182142E70
	public string ToString(int fieldCount) { }

	// RVA: 0x2142840 Offset: 0x2141C40 VA: 0x182142840
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x2142D80 Offset: 0x2142180 VA: 0x182142D80
	public static Version Parse(string input) { }

	// RVA: 0x2143520 Offset: 0x2142920 VA: 0x182143520
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x21433D0 Offset: 0x21427D0 VA: 0x1821433D0
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x2144180 Offset: 0x2143580 VA: 0x182144180
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x2144300 Offset: 0x2143700 VA: 0x182144300
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x2144480 Offset: 0x2143880 VA: 0x182144480
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x2144400 Offset: 0x2143800 VA: 0x182144400
	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2144240 Offset: 0x2143640 VA: 0x182144240
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2143B90 Offset: 0x2142F90 VA: 0x182143B90
	private static void .cctor() { }

}

internal enum Version.ParseFailureKind // TypeDefIndex: 335
{	// Fields
	public int value__; // 0x0
	public const Version.ParseFailureKind ArgumentNullException = 0;
	public const Version.ParseFailureKind ArgumentException = 1;
	public const Version.ParseFailureKind ArgumentOutOfRangeException = 2;
	public const Version.ParseFailureKind FormatException = 3;

}

internal struct Version.VersionResult // TypeDefIndex: 336
{	// Fields
	internal Version m_parsedVersion; // 0x0
	internal Version.ParseFailureKind m_failure; // 0x8
	internal string m_exceptionArgument; // 0x10
	internal string m_argumentName; // 0x18
	internal bool m_canThrow; // 0x20

	// Methods

	// RVA: 0x234610 Offset: 0x233A10 VA: 0x180234610
	internal void Init(string argumentName, bool canThrow) { }

	// RVA: 0x234630 Offset: 0x233A30 VA: 0x180234630
	internal void SetFailure(Version.ParseFailureKind failure) { }

	// RVA: 0x234620 Offset: 0x233A20 VA: 0x180234620
	internal void SetFailure(Version.ParseFailureKind failure, string argument) { }

	// RVA: 0x234600 Offset: 0x233A00 VA: 0x180234600
	internal Exception GetVersionParseException() { }

}

public static class Version // TypeDefIndex: 11551
{	// Fields
	public const int Current = 1510;

}

