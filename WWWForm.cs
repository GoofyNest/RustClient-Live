public class WWWForm // TypeDefIndex: 4125
{	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38

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

