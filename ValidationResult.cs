public class ValidationResult // TypeDefIndex: 1737
{	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x1AC1450 Offset: 0x1AC0850 VA: 0x181AC1450
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_Trusted() { }

	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public bool get_UserDenied() { }

}

