public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 932
{
	private IntPtr _token;
	private string _type;
	private WindowsAccountType _account;
	private bool _authenticated;
	private string _name;
	private SerializationInfo _info;
	private static IntPtr invalidWindows;

	public sealed override string AuthenticationType { get; }
	public override string Name { get; }


	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute]
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

