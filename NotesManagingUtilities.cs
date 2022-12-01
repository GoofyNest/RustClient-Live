public static class NotesManagingUtilities // TypeDefIndex: 7463
{

	[ExtensionAttribute]
	public static ICollection<Note> GetNotes(EventsCollection eventsCollection, NoteDetectionSettings settings) { }

	[ExtensionAttribute]
	public static ICollection<Note> GetNotes(IEnumerable<TrackChunk> trackChunks, NoteDetectionSettings settings) { }

	[ExtensionAttribute]
	public static ICollection<Note> GetNotes(MidiFile file, NoteDetectionSettings settings) { }

}

private sealed class NotesManagingUtilities.<>c // TypeDefIndex: 7464
{
	public static readonly NotesManagingUtilities.<>c <>9;
	public static Func<TrackChunk, EventsCollection> <>9__16_0;
	public static Func<EventsCollection, int> <>9__16_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal EventsCollection <GetNotes>

	internal int <GetNotes>

}

