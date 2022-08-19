public class VersionInfo // TypeDefIndex: 11563
{	// Fields
	public const byte Major = 2;
	public const byte Minor = 0;
	public const byte Release = 0;
	private static string StageSuffix; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_major; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_minor; // 0x14
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_release; // 0x18

	// Properties
	public int Number { get; }

	// Methods

	// RVA: 0x83AA60 Offset: 0x839E60 VA: 0x18083AA60
	public static string StaticToString() { }

	// RVA: 0x83AB40 Offset: 0x839F40 VA: 0x18083AB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x83ACE0 Offset: 0x83A0E0 VA: 0x18083ACE0
	public int get_Number() { }

	// RVA: 0x83ACB0 Offset: 0x83A0B0 VA: 0x18083ACB0
	private void .ctor() { }

	// RVA: 0x83AC60 Offset: 0x83A060 VA: 0x18083AC60
	private void .ctor(byte major, byte minor, byte release) { }

	// RVA: 0x83A9E0 Offset: 0x839DE0 VA: 0x18083A9E0
	public static VersionInfo Current() { }

	// RVA: 0x83AA30 Offset: 0x839E30 VA: 0x18083AA30
	public static bool Matches(VersionInfo version) { }

	// RVA: 0x83AC20 Offset: 0x83A020 VA: 0x18083AC20
	private static void .cctor() { }

}

