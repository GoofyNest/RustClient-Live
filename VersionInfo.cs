public class VersionInfo // TypeDefIndex: 13259
{
	public const byte Major = 2;
	public const byte Minor = 0;
	public const byte Release = 0;
	private static string StageSuffix; 
	[SerializeField] 
	private int m_major; 
	[SerializeField] 
	private int m_minor; 
	[SerializeField] 
	private int m_release; 

	public int Number { get; }


	public static string StaticToString() { }

	public override string ToString() { }

	public int get_Number() { }

	private void .ctor() { }

	private void .ctor(byte major, byte minor, byte release) { }

	public static VersionInfo Current() { }

	public static bool Matches(VersionInfo version) { }

	private static void .cctor() { }

}

