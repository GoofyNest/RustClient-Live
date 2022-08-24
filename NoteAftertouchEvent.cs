public sealed class NoteAftertouchEvent : ChannelEvent // TypeDefIndex: 7524
{
public SevenBitNumber NoteNumber { get; }
public SevenBitNumber AftertouchValue { get; }


public void .ctor() { }

public SevenBitNumber get_NoteNumber() { }

public SevenBitNumber get_AftertouchValue() { }

internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

protected override MidiEvent CloneEvent() { }

public override string ToString() { }

}

