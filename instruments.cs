public class instruments : ConsoleSystem // TypeDefIndex: 11933
{	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; // 0x0
	[ClientVar] // RVA: 0xA7880 Offset: 0xA6C80 VA: 0x1800A7880
	public static bool processSustainPedal; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <debugNotes>k__BackingField; // 0x2

	[ClientVar] // RVA: 0xA9740 Offset: 0xA8B40 VA: 0x1800A9740
	public static bool debugMidi { get; set; }
	[ClientVar] // RVA: 0xA97F0 Offset: 0xA8BF0 VA: 0x1800A97F0
	public static bool debugNotes { get; set; }


	public static bool get_debugMidi() { }

	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_debugNotes(bool value) { }

	[ClientVar] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7C10 Offset: 0xA7010 VA: 0x1800A7C10
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7CE0 Offset: 0xA70E0 VA: 0x1800A7CE0
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7D70 Offset: 0xA7170 VA: 0x1800A7D70
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	private static string MidiBindingPath(uint forId) { }

	[ClientVar] // RVA: 0xA7DE0 Offset: 0xA71E0 VA: 0x1800A7DE0
	public static void playnote(ConsoleSystem.Arg arg) { }

	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7F20 Offset: 0xA7320 VA: 0x1800A7F20
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9320 Offset: 0xA8720 VA: 0x1800A9320
	public static void playrecording(ConsoleSystem.Arg arg) { }

	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	private static string GetTargetRecording(string findName) { }

	[ClientVar] // RVA: 0xA93C0 Offset: 0xA87C0 VA: 0x1800A93C0
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA94B0 Offset: 0xA88B0 VA: 0x1800A94B0
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA95C0 Offset: 0xA89C0 VA: 0x1800A95C0
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9600 Offset: 0xA8A00 VA: 0x1800A9600
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

