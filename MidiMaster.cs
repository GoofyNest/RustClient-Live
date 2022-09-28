public static class MidiMaster // TypeDefIndex: 7620
{
	public static MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public static MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public static MidiDriver.KnobDelegate knobDelegate { get; set; }


	public static MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	public static void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	public static MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	public static void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	public static MidiDriver.KnobDelegate get_knobDelegate() { }

	public static void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	public static float GetKey(MidiChannel channel, int noteNumber) { }

	public static float GetKey(int noteNumber) { }

	public static bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	public static bool GetKeyDown(int noteNumber) { }

	public static bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	public static bool GetKeyUp(int noteNumber) { }

	public static int[] GetKnobNumbers(MidiChannel channel) { }

	public static int[] GetKnobNumbers() { }

	public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0) { }

	public static float GetKnob(int knobNumber, float defaultValue = 0) { }

	public static void ToggleEnabled(bool state) { }

}

