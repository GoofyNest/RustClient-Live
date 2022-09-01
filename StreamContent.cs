public class StreamContent : HttpContent // TypeDefIndex: 5757
{
	private readonly Stream content; 
	private readonly int bufferSize; 
	private readonly CancellationToken cancellationToken; 
	private readonly long startPosition; 
	private bool contentCopied; 


	public void .ctor(Stream content) { }

	public void .ctor(Stream content, int bufferSize) { }

	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	protected override Task<Stream> CreateContentReadStreamAsync() { }

	protected override void Dispose(bool disposing) { }

	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected internal override bool TryComputeLength(out long length) { }

}

