internal class UnityLogWriter : TextWriter // TypeDefIndex: 3460
{
	public override Encoding Encoding { get; }


	[ThreadAndSerializationSafeAttribute] 
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] 
	private static void WriteStringToUnityLogImpl(string s) { }

	public static void Init() { }

	public override Encoding get_Encoding() { }

	public override void Write(char value) { }

	public override void Write(string s) { }

	public override void Write(char[] buffer, int index, int count) { }

	public void .ctor() { }

}

