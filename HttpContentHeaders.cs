public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 5777
{
	private readonly HttpContent content; 

	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }


	internal void .ctor(HttpContent content) { }

	public Nullable<long> get_ContentLength() { }

	public MediaTypeHeaderValue get_ContentType() { }

	public void set_ContentType(MediaTypeHeaderValue value) { }

}

