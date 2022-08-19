public class MidiDriver // TypeDefIndex: 7642
{	// Fields
	private MidiDriver.ChannelState[] _channelArray; // 0x10
	private int _lastFrame; // 0x18
	private bool enabled; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MidiDriver.NoteOnDelegate <noteOnDelegate>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MidiDriver.NoteOffDelegate <noteOffDelegate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MidiDriver.KnobDelegate <knobDelegate>k__BackingField; // 0x30
	private static MidiDriver _instance; // 0x0

	// Properties
	public MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public MidiDriver.KnobDelegate knobDelegate { get; set; }
	public static MidiDriver Instance { get; }

	// Methods

	// RVA: 0x23113F0 Offset: 0x23107F0 VA: 0x1823113F0
	public float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2311280 Offset: 0x2310680 VA: 0x182311280
	public bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2311340 Offset: 0x2310740 VA: 0x182311340
	public bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x23114D0 Offset: 0x23108D0 VA: 0x1823114D0
	public int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x23115C0 Offset: 0x23109C0 VA: 0x1823115C0
	public float GetKnob(MidiChannel channel, int knobNumber, float defaultValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public MidiDriver.KnobDelegate get_knobDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x2311C30 Offset: 0x2311030 VA: 0x182311C30
	private void .ctor() { }

	// RVA: 0x7E8E40 Offset: 0x7E8240 VA: 0x1807E8E40
	public void ToggleEnabled(bool state) { }

	// RVA: 0x2311180 Offset: 0x2310580 VA: 0x182311180
	public void ClearOutstandingData() { }

	// RVA: 0x23116B0 Offset: 0x2310AB0 VA: 0x1823116B0
	private void UpdateIfNeeded() { }

	// RVA: 0x23116F0 Offset: 0x2310AF0 VA: 0x1823116F0
	public void Update() { }

	// RVA: 0x2311210 Offset: 0x2310610 VA: 0x182311210
	public static extern ulong DequeueIncomingData() { }

	// RVA: 0x2311DB0 Offset: 0x23111B0 VA: 0x182311DB0
	public static MidiDriver get_Instance() { }

}

private class MidiDriver.ChannelState // TypeDefIndex: 7643
{	// Fields
	public float[] _noteArray; // 0x10
	public Dictionary<int, float> _knobMap; // 0x18

	// Methods

	// RVA: 0x2310DF0 Offset: 0x23101F0 VA: 0x182310DF0
	public void .ctor() { }

}

public sealed class MidiDriver.NoteOnDelegate : MulticastDelegate // TypeDefIndex: 7644
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2310F20 Offset: 0x2310320 VA: 0x182310F20 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x2312610 Offset: 0x2311A10 VA: 0x182312610 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, float velocity, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.NoteOffDelegate : MulticastDelegate // TypeDefIndex: 7645
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A3CB30 Offset: 0x1A3BF30 VA: 0x181A3CB30 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note) { }

	// RVA: 0x2312580 Offset: 0x2311980 VA: 0x182312580 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.KnobDelegate : MulticastDelegate // TypeDefIndex: 7646
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2310F20 Offset: 0x2310320 VA: 0x182310F20 Slot: 12
	public virtual void Invoke(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x2310E80 Offset: 0x2310280 VA: 0x182310E80 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int knobNumber, float knobValue, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

