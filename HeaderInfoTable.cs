internal class HeaderInfoTable // TypeDefIndex: 2916
{	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x1333850 Offset: 0x1332C50 VA: 0x181333850
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1333660 Offset: 0x1332A60 VA: 0x181333660
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1333900 Offset: 0x1332D00 VA: 0x181333900
	private static void .cctor() { }

	// RVA: 0x1335EA0 Offset: 0x13352A0 VA: 0x181335EA0
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

