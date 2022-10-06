public class ByteArrayContent : HttpContent // TypeDefIndex: 5740
{

internal class <Module>

internal class <Module>

internal class <Module>

public class ByteArrayContent : HttpContent
	private readonly byte[] content; 
	private readonly int offset; 
	private readonly int count; 


	public void .ctor(byte[] content) { }

	protected override Task<Stream> CreateContentReadStreamAsync() { }

	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected internal override bool TryComputeLength(out long length) { }

}

