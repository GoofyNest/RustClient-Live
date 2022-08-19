public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 932
{	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17C5220 Offset: 0x17C4620 VA: 0x1817C5220
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x17C51E0 Offset: 0x17C45E0 VA: 0x1817C51E0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17C49E0 Offset: 0x17C3DE0 VA: 0x1817C49E0 Slot: 14
	public void Dispose() { }

	// RVA: 0x17C4A30 Offset: 0x17C3E30 VA: 0x1817C4A30
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x17C4C00 Offset: 0x17C4000 VA: 0x1817C4C00 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x17C53A0 Offset: 0x17C47A0 VA: 0x1817C53A0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17C4DF0 Offset: 0x17C41F0 VA: 0x1817C4DF0 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17C50B0 Offset: 0x17C44B0 VA: 0x1817C50B0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C4CC0 Offset: 0x17C40C0 VA: 0x1817C4CC0
	private void SetToken(IntPtr token) { }

	// RVA: 0x17C4A20 Offset: 0x17C3E20 VA: 0x1817C4A20
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x17C4A20 Offset: 0x17C3E20 VA: 0x1817C4A20
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x17C51A0 Offset: 0x17C45A0 VA: 0x1817C51A0
	private static void .cctor() { }

}

