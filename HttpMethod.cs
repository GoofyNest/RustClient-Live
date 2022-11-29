public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 5759
{
	private static readonly HttpMethod delete_method; 
	private static readonly HttpMethod get_method; 
	private static readonly HttpMethod head_method; 
	private static readonly HttpMethod options_method; 
	private static readonly HttpMethod post_method; 
	private static readonly HttpMethod put_method; 
	private static readonly HttpMethod trace_method; 
	private readonly string method; 

	public static HttpMethod Get { get; }
	public string Method { get; }
	public static HttpMethod Post { get; }


	public void .ctor(string method) { }

	public static HttpMethod get_Get() { }

	public string get_Method() { }

	public static HttpMethod get_Post() { }

	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	public bool Equals(HttpMethod other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private static void .cctor() { }

}

