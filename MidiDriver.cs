public class MidiDriver // TypeDefIndex: 7660
{
	private MidiDriver.ChannelState[] _channelArray;
	private int _lastFrame;
	private bool enabled;
	[CompilerGeneratedAttribute]
	private MidiDriver.NoteOnDelegate <noteOnDelegate>k__BackingField;
	[CompilerGeneratedAttribute]
	private MidiDriver.NoteOffDelegate <noteOffDelegate>k__BackingField;
	[CompilerGeneratedAttribute]
	private MidiDriver.KnobDelegate <knobDelegate>k__BackingField;
	private static MidiDriver _instance;

	public MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public MidiDriver.KnobDelegate knobDelegate { get; set; }
	public static MidiDriver Instance { get; }


	public float GetKey(MidiChannel channel, int noteNumber) { }

	public bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	public bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	public int[] GetKnobNumbers(MidiChannel channel) { }

	public float GetKnob(MidiChannel channel, int knobNumber, float defaultValue) { }

	[CompilerGeneratedAttribute]
	public MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	[CompilerGeneratedAttribute]
	public void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	[CompilerGeneratedAttribute]
	public MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	[CompilerGeneratedAttribute]
	public void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	[CompilerGeneratedAttribute]
	public MidiDriver.KnobDelegate get_knobDelegate() { }

	[CompilerGeneratedAttribute]
	public void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	private void .ctor() { }

	public void ToggleEnabled(bool state) { }

	public void ClearOutstandingData() { }

	private void UpdateIfNeeded() { }

	public void Update() { }

	public static extern ulong DequeueIncomingData() { }

	public static MidiDriver get_Instance() { }

}

private class MidiDriver.ChannelState // TypeDefIndex: 7661
{
	public float[] _noteArray;
	public Dictionary<int, float> _knobMap;


	public void .ctor() { }

}

public sealed class MidiDriver.NoteOnDelegate : MulticastDelegate // TypeDefIndex: 7662
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(MidiChannel channel, int note, float velocity) { }

	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, float velocity, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.NoteOffDelegate : MulticastDelegate // TypeDefIndex: 7663
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(MidiChannel channel, int note) { }

	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.KnobDelegate : MulticastDelegate // TypeDefIndex: 7664
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(MidiChannel channel, int knobNumber, float knobValue) { }

	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int knobNumber, float knobValue, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

