public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 5772
{	private readonly HttpContent content; // 0x20

	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }


	internal void .ctor(HttpContent content) { }

	public Nullable<long> get_ContentLength() { }

	public MediaTypeHeaderValue get_ContentType() { }

	public void set_ContentType(MediaTypeHeaderValue value) { }

}

