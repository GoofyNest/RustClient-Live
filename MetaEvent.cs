public abstract class MetaEvent : MidiEvent // TypeDefIndex: 7489
{

	protected void .ctor() { }

	internal void .ctor(MidiEventType eventType) { }

	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, int size);

}

