public sealed class Note : IComparable<Note> // TypeDefIndex: 7449
{

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748

internal class <Module>

public sealed class Note : IComparable<Note>
	private static readonly ConcurrentDictionary<SevenBitNumber, Note> Cache;
	[CompilerGeneratedAttribute]
	private readonly SevenBitNumber <NoteNumber>k__BackingField;

	public SevenBitNumber NoteNumber { get; }
	public NoteName NoteName { get; }
	public int Octave { get; }


	private void .ctor(SevenBitNumber noteNumber) { }

	[CompilerGeneratedAttribute]
	public SevenBitNumber get_NoteNumber() { }

	public NoteName get_NoteName() { }

	public int get_Octave() { }

	public static Note Get(SevenBitNumber noteNumber) { }

	public static bool op_Equality(Note note1, Note note2) { }

	public int CompareTo(Note other) { }

	public override string ToString() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

public class Note : ILengthedObject, ITimedObject // TypeDefIndex: 7454
{
	public static readonly SevenBitNumber DefaultVelocity;
	[CompilerGeneratedAttribute]
	private readonly TimedEvent <TimedNoteOnEvent>k__BackingField;
	[CompilerGeneratedAttribute]
	private readonly TimedEvent <TimedNoteOffEvent>k__BackingField;

	public long Time { get; }
	public long Length { get; }
	public SevenBitNumber NoteNumber { get; }
	public SevenBitNumber Velocity { get; set; }
	public SevenBitNumber OffVelocity { set; }
	public FourBitNumber Channel { set; }
	public NoteName NoteName { get; }
	public int Octave { get; }
	internal TimedEvent TimedNoteOnEvent { get; }
	internal TimedEvent TimedNoteOffEvent { get; }
	internal Note UnderlyingNote { get; }


	internal void .ctor(TimedEvent timedNoteOnEvent, TimedEvent timedNoteOffEvent) { }

	public long get_Time() { }

	public long get_Length() { }

	public SevenBitNumber get_NoteNumber() { }

	public SevenBitNumber get_Velocity() { }

	public void set_Velocity(SevenBitNumber value) { }

	public void set_OffVelocity(SevenBitNumber value) { }

	public void set_Channel(FourBitNumber value) { }

	public NoteName get_NoteName() { }

	public int get_Octave() { }

	[CompilerGeneratedAttribute]
	internal TimedEvent get_TimedNoteOnEvent() { }

	[CompilerGeneratedAttribute]
	internal TimedEvent get_TimedNoteOffEvent() { }

	internal Note get_UnderlyingNote() { }

	public override string ToString() { }

	private static void .cctor() { }

}

public class Note : ConsoleSystem // TypeDefIndex: 13754
{

	[ClientVar]
	public static void craft_add(ConsoleSystem.Arg args) { }

	[ClientVar]
	public static void craft_start(ConsoleSystem.Arg args) { }

	[ClientVar]
	public static void craft_done(ConsoleSystem.Arg args) { }

	[ClientVar]
	public static void craft_fasttracked(ConsoleSystem.Arg args) { }

	[ClientVar]
	public static void inv(ConsoleSystem.Arg args) { }

	public void .ctor() { }

}

