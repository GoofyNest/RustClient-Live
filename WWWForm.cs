public class WWWForm // TypeDefIndex: 4130
{
	private List<byte[]> formData; 
	private List<string> fieldNames; 
	private List<string> fileNames; 
	private List<string> types; 
	private byte[] boundary; 
	private bool containsFiles; 

	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }


	internal static Encoding get_DefaultEncoding() { }

	public void .ctor() { }

	public void AddField(string fieldName, string value) { }

	public void AddField(string fieldName, string value, Encoding e) { }

	public Dictionary<string, string> get_headers() { }

	public byte[] get_data() { }

}

