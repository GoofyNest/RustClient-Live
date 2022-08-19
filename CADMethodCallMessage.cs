internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1228
{	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal string get_Uri() { }

	// RVA: 0x146B3E0 Offset: 0x146A7E0 VA: 0x18146B3E0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x146B650 Offset: 0x146AA50 VA: 0x18146B650
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x146B570 Offset: 0x146A970 VA: 0x18146B570
	internal ArrayList GetArguments() { }

	// RVA: 0x146B560 Offset: 0x146A960 VA: 0x18146B560
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_PropertiesCount() { }

}

