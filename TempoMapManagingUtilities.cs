public static class TempoMapManagingUtilities // TypeDefIndex: 7455
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FBC10 Offset: 0x21FB010 VA: 0x1821FBC10
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FBBB0 Offset: 0x21FAFB0 VA: 0x1821FBBB0
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7456
{	// Fields
	public static readonly TempoMapManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, bool> <>9__3_0; // 0x8
	public static Func<TrackChunk, EventsCollection> <>9__3_1; // 0x10
	public static Func<EventsCollection, int> <>9__3_2; // 0x18

	// Methods

	// RVA: 0x2200040 Offset: 0x21FF440 VA: 0x182200040
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA4D0 Offset: 0xDE98D0 VA: 0x180DEA4D0
	internal bool <GetTempoMap>b__3_0(TrackChunk c) { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440
	internal EventsCollection <GetTempoMap>b__3_1(TrackChunk c) { }

	// RVA: 0x21FFEB0 Offset: 0x21FF2B0 VA: 0x1821FFEB0
	internal int <GetTempoMap>b__3_2(EventsCollection c) { }

}

