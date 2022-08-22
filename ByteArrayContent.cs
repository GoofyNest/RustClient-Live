public class ByteArrayContent : HttpContent // TypeDefIndex: 5736
{
internal class <Module> // TypeDefIndex: 5733

internal class <Module> // TypeDefIndex: 5734

internal class <Module> // TypeDefIndex: 5735

public class ByteArrayContent : HttpContent // TypeDefIndex: 5736
	private readonly byte[] content; // 0x30
	private readonly int offset; // 0x38
	private readonly int count; // 0x3C


	public void .ctor(byte[] content) { }

	protected override Task<Stream> CreateContentReadStreamAsync() { }

	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected internal override bool TryComputeLength(out long length) { }

}

