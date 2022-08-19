public class MidiConvar : MonoBehaviour // TypeDefIndex: 9312
{	// Fields
	private static bool _enabled; // 0x0
	[ClientVar] // RVA: 0xE7120 Offset: 0xE6520 VA: 0x1800E7120
	public static bool debugMode; // 0x1
	private static MidiConvar Instance; // 0x8
	private List<MidiConvar.KnobBinding> knobBindings; // 0x18
	private List<MidiConvar.NoteBinding> noteBindings; // 0x20

	// Properties
	[ClientVar] // RVA: 0xE7560 Offset: 0xE6960 VA: 0x1800E7560
	public static bool Enabled { get; set; }

	// Methods

	// RVA: 0x96B910 Offset: 0x96AD10 VA: 0x18096B910
	public static bool get_Enabled() { }

	// RVA: 0x96B970 Offset: 0x96AD70 VA: 0x18096B970
	public static void set_Enabled(bool value) { }

	[ClientVar] // RVA: 0xE7160 Offset: 0xE6560 VA: 0x1800E7160
	// RVA: 0x968BD0 Offset: 0x967FD0 VA: 0x180968BD0
	public static void BindKnob(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE71F0 Offset: 0xE65F0 VA: 0x1800E71F0
	// RVA: 0x968760 Offset: 0x967B60 VA: 0x180968760
	public static void BindKnobRelative(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7300 Offset: 0xE6700 VA: 0x1800E7300
	// RVA: 0x968510 Offset: 0x967910 VA: 0x180968510
	public static void BindKeyOn(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE73C0 Offset: 0xE67C0 VA: 0x1800E73C0
	// RVA: 0x9682C0 Offset: 0x9676C0 VA: 0x1809682C0
	public static void BindKeyOff(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x96A650 Offset: 0x969A50 VA: 0x18096A650
	public static void PrintBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x9692A0 Offset: 0x9686A0 VA: 0x1809692A0
	public static void ClearAllBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0xE7520 Offset: 0xE6920 VA: 0x1800E7520
	// RVA: 0x96B3E0 Offset: 0x96A7E0 VA: 0x18096B3E0
	public static void ReloadBindings(ConsoleSystem.Arg arg) { }

	// RVA: 0x96A480 Offset: 0x969880 VA: 0x18096A480
	private void OnEnable() { }

	// RVA: 0x96A2F0 Offset: 0x9696F0 VA: 0x18096A2F0
	private void OnDisable() { }

	// RVA: 0x96B840 Offset: 0x96AC40 VA: 0x18096B840
	private void Update() { }

	// RVA: 0x969460 Offset: 0x968860 VA: 0x180969460
	private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue) { }

	// RVA: 0x969BB0 Offset: 0x968FB0 VA: 0x180969BB0
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x969F50 Offset: 0x969350 VA: 0x180969F50
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x969160 Offset: 0x968560 VA: 0x180969160
	private int ChannelToInt(MidiChannel channel) { }

	// RVA: 0x9690B0 Offset: 0x9684B0 VA: 0x1809690B0
	private static bool CanRunBinds() { }

	// RVA: 0x967E60 Offset: 0x967260 VA: 0x180967E60
	public void AddKnobBinding(int knob, string convar, float minValue, float maxValue, int channel) { }

	// RVA: 0x967F60 Offset: 0x967360 VA: 0x180967F60
	public void AddKnobBinding(int knob, string convar, float rate, int channel) { }

	// RVA: 0x968050 Offset: 0x967450 VA: 0x180968050
	public void AddNoteBinding(int note, string convar, MidiConvar.NoteType type, int channel, bool cycled) { }

	// RVA: 0x96B4E0 Offset: 0x96A8E0 VA: 0x18096B4E0
	private bool RemoveBindingForKnob(int knob, int channel) { }

	// RVA: 0x96B5F0 Offset: 0x96A9F0 VA: 0x18096B5F0
	private bool RemoveBindingForNote(int note, int channel, MidiConvar.NoteType t) { }

	// RVA: 0x96B730 Offset: 0x96AB30 VA: 0x18096B730
	private void SaveBindings() { }

	// RVA: 0x9699E0 Offset: 0x968DE0 VA: 0x1809699E0
	private void LoadBindings() { }

	// RVA: 0x9693F0 Offset: 0x9687F0 VA: 0x1809693F0
	private string GetBindingsPath() { }

	// RVA: 0x96A760 Offset: 0x969B60 VA: 0x18096A760
	private string PrintBindings() { }

	// RVA: 0x969230 Offset: 0x968630 VA: 0x180969230
	private void ClearAllBindings() { }

	// RVA: 0x96B870 Offset: 0x96AC70 VA: 0x18096B870
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public enum MidiConvar.NoteType // TypeDefIndex: 9313
{	// Fields
	public int value__; // 0x0
	public const MidiConvar.NoteType NoteOn = 0;
	public const MidiConvar.NoteType NoteOff = 1;

}

private struct MidiConvar.KnobBinding // TypeDefIndex: 9314
{	// Fields
	public int knobNumber; // 0x0
	public string convar; // 0x8
	public float minValue; // 0x10
	public float maxValue; // 0x14
	public int channel; // 0x18
	public bool relative; // 0x1C

}

private struct MidiConvar.NoteBinding // TypeDefIndex: 9315
{	// Fields
	public int noteNumber; // 0x0
	public string[] convar; // 0x8
	public MidiConvar.NoteType noteType; // 0x10
	public int channel; // 0x14
	public bool cycled; // 0x18
	public int cycleIndex; // 0x1C

}

private struct MidiConvar.SavedBindings // TypeDefIndex: 9316
{	// Fields
	public List<MidiConvar.KnobBinding> knobs; // 0x0
	public List<MidiConvar.NoteBinding> notes; // 0x8

}

