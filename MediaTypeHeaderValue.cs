public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 5788
{
	internal List<NameValueHeaderValue> parameters; 
	internal string media_type; 

	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }


	public void .ctor(string mediaType) { }

	protected void .ctor(MediaTypeHeaderValue source) { }

	internal void .ctor() { }

	public string get_CharSet() { }

	public void set_CharSet(string value) { }

	public string get_MediaType() { }

	public void set_MediaType(string value) { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 5789
{
	public static readonly MediaTypeHeaderValue.<>c <>9; 
	public static Predicate<NameValueHeaderValue> <>9__6_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

}

