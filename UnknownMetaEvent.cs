public sealed class UnknownMetaEvent : MetaEvent // TypeDefIndex: 7552
{
	[CompilerGeneratedAttribute] 
	private readonly byte <StatusByte>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private byte[] <Data>k__BackingField; 

	public byte StatusByte { get; }
	public byte[] Data { get; set; }


	internal void .ctor(byte statusByte) { }

	internal void .ctor(byte statusByte, byte[] data) { }

	[CompilerGeneratedAttribute] 
	public byte get_StatusByte() { }

	[CompilerGeneratedAttribute] 
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] 
	private void set_Data(byte[] value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

