public class ValidationResult // TypeDefIndex: 1737
{
	private bool trusted;
	private bool user_denied;
	private int error_code;
	private Nullable<MonoSslPolicyErrors> policy_errors;

	public bool Trusted { get; }
	public bool UserDenied { get; }


	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	public bool get_Trusted() { }

	public bool get_UserDenied() { }

}

