public class MidiConvar : MonoBehaviour // TypeDefIndex: 11033
{
	private static bool _enabled; 
	[ClientVar] 
	public static bool debugMode; 
	private static MidiConvar Instance; 
	private List<MidiConvar.KnobBinding> knobBindings; 
	private List<MidiConvar.NoteBinding> noteBindings; 

	[ClientVar] 
	public static bool Enabled { get; set; }


	public static bool get_Enabled() { }

	public static void set_Enabled(bool value) { }

	[ClientVar] 
	public static void BindKnob(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void BindKnobRelative(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void BindKeyOn(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void BindKeyOff(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void PrintBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ClearAllBindings(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ReloadBindings(ConsoleSystem.Arg arg) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue) { }

	private void NoteOffDelegate(MidiChannel channel, int note) { }

	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	private int ChannelToInt(MidiChannel channel) { }

	private static bool CanRunBinds() { }

	public void AddKnobBinding(int knob, string convar, float minValue, float maxValue, int channel) { }

	public void AddKnobBinding(int knob, string convar, float rate, int channel) { }

	public void AddNoteBinding(int note, string convar, MidiConvar.NoteType type, int channel, bool cycled) { }

	private bool RemoveBindingForKnob(int knob, int channel) { }

	private bool RemoveBindingForNote(int note, int channel, MidiConvar.NoteType t) { }

	private void SaveBindings() { }

	private void LoadBindings() { }

	private string GetBindingsPath() { }

	private string PrintBindings() { }

	private void ClearAllBindings() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum MidiConvar.NoteType // TypeDefIndex: 11034
{
	public int value__; 
	public const MidiConvar.NoteType NoteOn = 0;
	public const MidiConvar.NoteType NoteOff = 1;

}

private struct MidiConvar.KnobBinding // TypeDefIndex: 11035
{
	public int knobNumber; 
	public string convar; 
	public float minValue; 
	public float maxValue; 
	public int channel; 
	public bool relative; 

}

private struct MidiConvar.NoteBinding // TypeDefIndex: 11036
{
	public int noteNumber; 
	public string[] convar; 
	public MidiConvar.NoteType noteType; 
	public int channel; 
	public bool cycled; 
	public int cycleIndex; 

}

private struct MidiConvar.SavedBindings // TypeDefIndex: 11037
{
	public List<MidiConvar.KnobBinding> knobs; 
	public List<MidiConvar.NoteBinding> notes; 

}

