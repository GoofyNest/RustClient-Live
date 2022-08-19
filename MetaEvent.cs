public abstract class MetaEvent : MidiEvent // TypeDefIndex: 7516
{	// Methods

	// RVA: 0x13968E0 Offset: 0x1395CE0 VA: 0x1813968E0
	protected void .ctor() { }

	// RVA: 0x1390B10 Offset: 0x138FF10 VA: 0x181390B10
	internal void .ctor(MidiEventType eventType) { }

	// RVA: 0x13968C0 Offset: 0x1395CC0 VA: 0x1813968C0 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, int size);

}

