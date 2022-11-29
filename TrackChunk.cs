public sealed class TrackChunk : MidiChunk // TypeDefIndex: 7525
{
	[CompilerGeneratedAttribute] 
	private readonly EventsCollection <Events>k__BackingField; 

	public EventsCollection Events { get; }


	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	public EventsCollection get_Events() { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

	public override string ToString() { }

	private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref Nullable<byte> channelEventStatusByte, out long deltaTime) { }

}

