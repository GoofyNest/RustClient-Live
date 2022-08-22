public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 932
{	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	public sealed override string AuthenticationType { get; }
	public override string Name { get; }


	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public void Dispose() { }

	public static WindowsIdentity GetCurrent() { }

	public virtual WindowsImpersonationContext Impersonate() { }

	public sealed override string get_AuthenticationType() { }

	public override string get_Name() { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetToken(IntPtr token) { }

	internal static IntPtr GetCurrentToken() { }

	private static string GetTokenName(IntPtr token) { }

	private static void .cctor() { }

}

