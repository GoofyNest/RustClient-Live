public static class TempoMapManagingUtilities // TypeDefIndex: 7455
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7456
{	public static readonly TempoMapManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, bool> <>9__3_0; // 0x8
	public static Func<TrackChunk, EventsCollection> <>9__3_1; // 0x10
	public static Func<EventsCollection, int> <>9__3_2; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetTempoMap>b__3_0(TrackChunk c) { }

	internal EventsCollection <GetTempoMap>b__3_1(TrackChunk c) { }

	internal int <GetTempoMap>b__3_2(EventsCollection c) { }

}

