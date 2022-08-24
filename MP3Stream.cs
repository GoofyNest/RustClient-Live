public class MP3Stream : Stream // TypeDefIndex: 7379
{
	private readonly Bitstream _BitStream; 
	private readonly Decoder _Decoder; 
	private readonly Buffer16BitStereo _Buffer; 
	private readonly Stream _SourceStream; 
private const int BACK_STREAM_BYTE_COUNT_REP = 0;
	private short _ChannelCountRep; 
	private readonly SoundFormat FormatRep; 
	private int _FrequencyRep; 
	[CompilerGeneratedAttribute] 
	private bool <IsEOF>k__BackingField; 

public bool IsEOF { get; set; }
public override bool CanRead { get; }
public override bool CanSeek { get; }
public override bool CanWrite { get; }
public override long Length { get; }
public override long Position { get; set; }
public int Frequency { get; }


	[CompilerGeneratedAttribute] 
public bool get_IsEOF() { }

	[CompilerGeneratedAttribute] 
protected void set_IsEOF(bool value) { }

public void .ctor(Stream sourceStream) { }

public void .ctor(Stream sourceStream, int chunkSize) { }

public override bool get_CanRead() { }

public override bool get_CanSeek() { }

public override bool get_CanWrite() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

public int get_Frequency() { }

public override void Flush() { }

public override long Seek(long offset, SeekOrigin origin) { }

public override void SetLength(long value) { }

public override void Write(byte[] buffer, int offset, int count) { }

public override int Read(byte[] buffer, int offset, int count) { }

public override void Close() { }

private bool ReadFrame() { }

}

