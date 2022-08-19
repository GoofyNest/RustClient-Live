internal class TplEtwProvider : EventSource // TypeDefIndex: 1594
{	// Fields
	public static TplEtwProvider Log; // 0x2B0AC40

	// Properties
	public bool Debug { get; }

	// Methods

	// RVA: 0x10E1E50 Offset: 0x10E1250 VA: 0x1810E1E50
	public bool get_Debug() { }

	// RVA: 0x10E1C40 Offset: 0x10E1040 VA: 0x1810E1C40
	public void DebugFacilityMessage(string Facility, string Message) { }

	// RVA: 0x10E1C10 Offset: 0x10E1010 VA: 0x1810E1C10
	public void DebugFacilityMessage1(string Facility, string Message, string Arg) { }

	// RVA: 0x10E1C70 Offset: 0x10E1070 VA: 0x1810E1C70
	public void SetActivityId(Guid Id) { }

	// RVA: 0x10E1DF0 Offset: 0x10E11F0 VA: 0x1810E1DF0
	public void .ctor() { }

	// RVA: 0x10E1D50 Offset: 0x10E1150 VA: 0x1810E1D50
	private static void .cctor() { }

}

public class TplEtwProvider.Keywords // TypeDefIndex: 1595
{	// Fields
	public const EventKeywords Debug = 1;

}

