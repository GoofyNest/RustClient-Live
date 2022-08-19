public static class MidiMaster // TypeDefIndex: 7647
{	// Properties
	public static MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public static MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public static MidiDriver.KnobDelegate knobDelegate { get; set; }

	// Methods

	// RVA: 0x23122A0 Offset: 0x23116A0 VA: 0x1823122A0
	public static MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	// RVA: 0x2312320 Offset: 0x2311720 VA: 0x182312320
	public static void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	// RVA: 0x2312280 Offset: 0x2311680 VA: 0x182312280
	public static MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	// RVA: 0x23122F0 Offset: 0x23116F0 VA: 0x1823122F0
	public static void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	// RVA: 0x2312260 Offset: 0x2311660 VA: 0x182312260
	public static MidiDriver.KnobDelegate get_knobDelegate() { }

	// RVA: 0x23122C0 Offset: 0x23116C0 VA: 0x1823122C0
	public static void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x23120E0 Offset: 0x23114E0 VA: 0x1823120E0
	public static float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x23120A0 Offset: 0x23114A0 VA: 0x1823120A0
	public static float GetKey(int noteNumber) { }

	// RVA: 0x2311FA0 Offset: 0x23113A0 VA: 0x182311FA0
	public static bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2311FE0 Offset: 0x23113E0 VA: 0x182311FE0
	public static bool GetKeyDown(int noteNumber) { }

	// RVA: 0x2312020 Offset: 0x2311420 VA: 0x182312020
	public static bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2312060 Offset: 0x2311460 VA: 0x182312060
	public static bool GetKeyUp(int noteNumber) { }

	// RVA: 0x2312120 Offset: 0x2311520 VA: 0x182312120
	public static int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x2312150 Offset: 0x2311550 VA: 0x182312150
	public static int[] GetKnobNumbers() { }

	// RVA: 0x23121D0 Offset: 0x23115D0 VA: 0x1823121D0
	public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2312180 Offset: 0x2311580 VA: 0x182312180
	public static float GetKnob(int knobNumber, float defaultValue = 0) { }

	// RVA: 0x2312230 Offset: 0x2311630 VA: 0x182312230
	public static void ToggleEnabled(bool state) { }

}

