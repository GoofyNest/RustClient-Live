public abstract class MidiEvent // TypeDefIndex: 7517
{
	internal long _deltaTime; 
	[CompilerGeneratedAttribute] 
	private readonly MidiEventType <EventType>k__BackingField; 

public MidiEventType EventType { get; }
public long DeltaTime { get; set; }


public void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] 
public MidiEventType get_EventType() { }

public long get_DeltaTime() { }

public void set_DeltaTime(long value) { }

internal abstract void Read(MidiReader reader, ReadingSettings settings, int size);

protected abstract MidiEvent CloneEvent();

public MidiEvent Clone() { }

}

