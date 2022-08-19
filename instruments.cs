public class instruments : ConsoleSystem // TypeDefIndex: 11933
{	// Fields
	public const string InstrumentsFolder = "instruments";
	private static bool _debugMidi; // 0x0
	[ClientVar] // RVA: 0xA7880 Offset: 0xA6C80 VA: 0x1800A7880
	public static bool processSustainPedal; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <debugNotes>k__BackingField; // 0x2

	// Properties
	[ClientVar] // RVA: 0xA9740 Offset: 0xA8B40 VA: 0x1800A9740
	public static bool debugMidi { get; set; }
	[ClientVar] // RVA: 0xA97F0 Offset: 0xA8BF0 VA: 0x1800A97F0
	public static bool debugNotes { get; set; }

	// Methods

	// RVA: 0x372070 Offset: 0x371470 VA: 0x180372070
	public static bool get_debugMidi() { }

	// RVA: 0x374580 Offset: 0x373980 VA: 0x180374580
	public static void set_debugMidi(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3720D0 Offset: 0x3714D0 VA: 0x1803720D0
	public static bool get_debugNotes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x374610 Offset: 0x373A10 VA: 0x180374610
	public static void set_debugNotes(bool value) { }

	[ClientVar] // RVA: 0xA7B30 Offset: 0xA6F30 VA: 0x1800A7B30
	// RVA: 0x373D30 Offset: 0x373130 VA: 0x180373D30
	public static void rebindMidi(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7C10 Offset: 0xA7010 VA: 0x1800A7C10
	// RVA: 0x373050 Offset: 0x372450 VA: 0x180373050
	public static void printMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7CE0 Offset: 0xA70E0 VA: 0x1800A7CE0
	// RVA: 0x371D20 Offset: 0x371120 VA: 0x180371D20
	public static void clearMidiBinds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7D70 Offset: 0xA7170 VA: 0x1800A7D70
	// RVA: 0x372130 Offset: 0x371530 VA: 0x180372130
	public static void midiInfo(ConsoleSystem.Arg arg) { }

	// RVA: 0x371250 Offset: 0x370650 VA: 0x180371250
	public static InstrumentMidiBindings GetBindingsForInstrument(uint id, bool createIfNone) { }

	// RVA: 0x371AA0 Offset: 0x370EA0 VA: 0x180371AA0
	public static void SaveBindingsForInstrument(uint id, InstrumentMidiBindings bindings) { }

	// RVA: 0x3718F0 Offset: 0x370CF0 VA: 0x1803718F0
	private static string MidiBindingPath(uint forId) { }

	[ClientVar] // RVA: 0xA7DE0 Offset: 0xA71E0 VA: 0x1800A7DE0
	// RVA: 0x3726B0 Offset: 0x371AB0 VA: 0x1803726B0
	public static void playnote(ConsoleSystem.Arg arg) { }

	// RVA: 0x371950 Offset: 0x370D50 VA: 0x180371950
	private static bool ParseNote(string input, out Notes note, out int octave, out InstrumentKeyController.NoteType type) { }

	// RVA: 0x371440 Offset: 0x370840 VA: 0x180371440
	private static InstrumentKeyController GetKeyController(BasePlayer player) { }

	[ClientVar] // RVA: 0xA7E80 Offset: 0xA7280 VA: 0x1800A7E80
	// RVA: 0x374670 Offset: 0x373A70 VA: 0x180374670
	public static void startrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA7F20 Offset: 0xA7320 VA: 0x1800A7F20
	// RVA: 0x374870 Offset: 0x373C70 VA: 0x180374870
	public static void stoprecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9320 Offset: 0xA8720 VA: 0x1800A9320
	// RVA: 0x372910 Offset: 0x371D10 VA: 0x180372910
	public static void playrecording(ConsoleSystem.Arg arg) { }

	// RVA: 0x371090 Offset: 0x370490 VA: 0x180371090
	private static void Convert(NoteName note, out Notes resultNote, out InstrumentKeyController.NoteType resultType) { }

	// RVA: 0x3715A0 Offset: 0x3709A0 VA: 0x1803715A0
	private static string GetTargetRecording(string findName) { }

	[ClientVar] // RVA: 0xA93C0 Offset: 0xA87C0 VA: 0x1800A93C0
	// RVA: 0x373580 Offset: 0x372980 VA: 0x180373580
	public static void printrecording(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA94B0 Offset: 0xA88B0 VA: 0x1800A94B0
	// RVA: 0x373B80 Offset: 0x372F80 VA: 0x180373B80
	public static void printrecordingpath(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA95C0 Offset: 0xA89C0 VA: 0x1800A95C0
	// RVA: 0x3724B0 Offset: 0x3718B0 VA: 0x1803724B0
	public static void overrideautoplay(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xA9600 Offset: 0xA8A00 VA: 0x1800A9600
	// RVA: 0x371F10 Offset: 0x371310 VA: 0x180371F10
	public static void clearautoplayoverride(ConsoleSystem.Arg arg) { }

	// RVA: 0x371CC0 Offset: 0x3710C0 VA: 0x180371CC0
	public void .ctor() { }

	// RVA: 0x371C70 Offset: 0x371070 VA: 0x180371C70
	private static void .cctor() { }

}

