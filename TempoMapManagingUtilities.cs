public static class TempoMapManagingUtilities // TypeDefIndex: 7473
{

	[ExtensionAttribute]
	public static TempoMap GetTempoMap(IEnumerable<TrackChunk> trackChunks, TimeDivision timeDivision) { }

	[ExtensionAttribute]
	public static TempoMap GetTempoMap(MidiFile file) { }

}

private sealed class TempoMapManagingUtilities.<>c // TypeDefIndex: 7474
{
	public static readonly TempoMapManagingUtilities.<>c <>9;
	public static Func<TrackChunk, bool> <>9__3_0;
	public static Func<TrackChunk, EventsCollection> <>9__3_1;
	public static Func<EventsCollection, int> <>9__3_2;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetTempoMap>

	internal EventsCollection <GetTempoMap>

	internal int <GetTempoMap>

}

