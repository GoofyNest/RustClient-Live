public static class NotesManagingUtilities // TypeDefIndex: 7447
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ICollection<Note> GetNotes(EventsCollection eventsCollection, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ICollection<Note> GetNotes(IEnumerable<TrackChunk> trackChunks, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ICollection<Note> GetNotes(MidiFile file, NoteDetectionSettings settings) { }

}

private sealed class NotesManagingUtilities.<>c // TypeDefIndex: 7448
{	public static readonly NotesManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, EventsCollection> <>9__16_0; // 0x8
	public static Func<EventsCollection, int> <>9__16_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal EventsCollection <GetNotes>b__16_0(TrackChunk c) { }

	internal int <GetNotes>b__16_1(EventsCollection e) { }

}

