public static class NotesManagingUtilities // TypeDefIndex: 7447
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FB4F0 Offset: 0x21FA8F0 VA: 0x1821FB4F0
	public static ICollection<Note> GetNotes(EventsCollection eventsCollection, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FB680 Offset: 0x21FAA80 VA: 0x1821FB680
	public static ICollection<Note> GetNotes(IEnumerable<TrackChunk> trackChunks, NoteDetectionSettings settings) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FBB50 Offset: 0x21FAF50 VA: 0x1821FBB50
	public static ICollection<Note> GetNotes(MidiFile file, NoteDetectionSettings settings) { }

}

private sealed class NotesManagingUtilities.<>c // TypeDefIndex: 7448
{	// Fields
	public static readonly NotesManagingUtilities.<>c <>9; // 0x0
	public static Func<TrackChunk, EventsCollection> <>9__16_0; // 0x8
	public static Func<EventsCollection, int> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x21FFF80 Offset: 0x21FF380 VA: 0x1821FFF80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440
	internal EventsCollection <GetNotes>b__16_0(TrackChunk c) { }

	// RVA: 0x21FFEB0 Offset: 0x21FF2B0 VA: 0x1821FFEB0
	internal int <GetNotes>b__16_1(EventsCollection e) { }

}

