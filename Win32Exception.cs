public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 2772
{	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	public int NativeErrorCode { get; }


	public void .ctor() { }

	public void .ctor(int error) { }

	public void .ctor(int error, string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public int get_NativeErrorCode() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static string GetErrorMessage(int error) { }

	private static void InitializeErrorMessages() { }

	private static void .cctor() { }

}

