public class ValidationResult // TypeDefIndex: 1737
{	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	public bool Trusted { get; }
	public bool UserDenied { get; }


	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	public bool get_Trusted() { }

	public bool get_UserDenied() { }

}

