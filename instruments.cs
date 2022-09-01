public class instruments : ConsoleSystem // TypeDefIndex: 11961
{
	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; 
	[ClientVar] 
	public static bool processSustainPedal; 
	[CompilerGeneratedAttribute] 
	private static bool <debugNotes>k__BackingField; 

	[ClientVar] 
	public static bool debugMidi { get; set; }
	[ClientVar] 
	public static bool debugNotes { get; set; }


	public static bool get_debugMidi() { }

	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] 
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] 
	public static void set_debugNotes(bool value) { }

	[ClientVar] 
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	private static string MidiBindingPath(uint forId) { }

	[ClientVar] 
	public static void playnote(ConsoleSystem.Arg arg) { }

	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] 
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void playrecording(ConsoleSystem.Arg arg) { }

	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	private static string GetTargetRecording(string findName) { }

	[ClientVar] 
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

