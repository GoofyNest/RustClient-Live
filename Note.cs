public sealed class Note : IComparable<Note> // TypeDefIndex: 7433
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 7417

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 7418

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 // TypeDefIndex: 7419

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 // TypeDefIndex: 7420

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 7421

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 // TypeDefIndex: 7422

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 // TypeDefIndex: 7423

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 // TypeDefIndex: 7424

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 // TypeDefIndex: 7425

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 // TypeDefIndex: 7426

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 7427

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 // TypeDefIndex: 7428

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 // TypeDefIndex: 7429

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 // TypeDefIndex: 7430

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 // TypeDefIndex: 7431

// Namespace: 
internal class <Module> // TypeDefIndex: 7432

// Namespace: Melanchall.DryWetMidi.MusicTheory
public sealed class Note : IComparable<Note> // TypeDefIndex: 7433
	// Fields
	private static readonly ConcurrentDictionary<SevenBitNumber, Note> Cache; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly SevenBitNumber <NoteNumber>k__BackingField; // 0x10

	// Properties
	public SevenBitNumber NoteNumber { get; }
	public NoteName NoteName { get; }
	public int Octave { get; }

	// Methods

	// RVA: 0x21FAB70 Offset: 0x21F9F70 VA: 0x1821FAB70
	private void .ctor(SevenBitNumber noteNumber) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x21FAC40 Offset: 0x21FA040 VA: 0x1821FAC40
	public NoteName get_NoteName() { }

	// RVA: 0x21FAD90 Offset: 0x21FA190 VA: 0x1821FAD90
	public int get_Octave() { }

	// RVA: 0x21FA2A0 Offset: 0x21F96A0 VA: 0x1821FA2A0
	public static Note Get(SevenBitNumber noteNumber) { }

	// RVA: 0x21FB020 Offset: 0x21FA420 VA: 0x1821FB020
	public static bool op_Equality(Note note1, Note note2) { }

	// RVA: 0x21FA160 Offset: 0x21F9560 VA: 0x1821FA160 Slot: 4
	public int CompareTo(Note other) { }

	// RVA: 0x21FA580 Offset: 0x21F9980 VA: 0x1821FA580 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FA190 Offset: 0x21F9590 VA: 0x1821FA190 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21FA280 Offset: 0x21F9680 VA: 0x1821FA280 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21FA760 Offset: 0x21F9B60 VA: 0x1821FA760
	private static void .cctor() { }

}

public class Note : ILengthedObject, ITimedObject // TypeDefIndex: 7438
{	// Fields
	public static readonly SevenBitNumber DefaultVelocity; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly TimedEvent <TimedNoteOnEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly TimedEvent <TimedNoteOffEvent>k__BackingField; // 0x18

	// Properties
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

	// Methods

	// RVA: 0x21FA7C0 Offset: 0x21F9BC0 VA: 0x1821FA7C0
	internal void .ctor(TimedEvent timedNoteOnEvent, TimedEvent timedNoteOffEvent) { }

	// RVA: 0xB242C0 Offset: 0xB236C0 VA: 0x180B242C0 Slot: 5
	public long get_Time() { }

	// RVA: 0x21FABA0 Offset: 0x21F9FA0 VA: 0x1821FABA0 Slot: 4
	public long get_Length() { }

	// RVA: 0x21FACB0 Offset: 0x21FA0B0 VA: 0x1821FACB0
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x21FAFB0 Offset: 0x21FA3B0 VA: 0x1821FAFB0
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x21FB1D0 Offset: 0x21FA5D0 VA: 0x1821FB1D0
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x21FB150 Offset: 0x21FA550 VA: 0x1821FB150
	public void set_OffVelocity(SevenBitNumber value) { }

	// RVA: 0x21FB0B0 Offset: 0x21FA4B0 VA: 0x1821FB0B0
	public void set_Channel(FourBitNumber value) { }

	// RVA: 0x21FABD0 Offset: 0x21F9FD0 VA: 0x1821FABD0
	public NoteName get_NoteName() { }

	// RVA: 0x21FAD20 Offset: 0x21FA120 VA: 0x1821FAD20
	public int get_Octave() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal TimedEvent get_TimedNoteOnEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal TimedEvent get_TimedNoteOffEvent() { }

	// RVA: 0x21FADF0 Offset: 0x21FA1F0 VA: 0x1821FADF0
	internal Note get_UnderlyingNote() { }

	// RVA: 0x21FA3B0 Offset: 0x21F97B0 VA: 0x1821FA3B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21FA700 Offset: 0x21F9B00 VA: 0x1821FA700
	private static void .cctor() { }

}

public class Note : ConsoleSystem // TypeDefIndex: 11945
{	// Methods

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x365B10 Offset: 0x364F10 VA: 0x180365B10
	public static void craft_add(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x365D20 Offset: 0x365120 VA: 0x180365D20
	public static void craft_start(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x365BF0 Offset: 0x364FF0 VA: 0x180365BF0
	public static void craft_done(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x365CB0 Offset: 0x3650B0 VA: 0x180365CB0
	public static void craft_fasttracked(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x365DE0 Offset: 0x3651E0 VA: 0x180365DE0
	public static void inv(ConsoleSystem.Arg args) { }

	// RVA: 0x365AB0 Offset: 0x364EB0 VA: 0x180365AB0
	public void .ctor() { }

}

