internal sealed class EmptyWebProxy : IWebProxy // TypeDefIndex: 2932
{
	private ICredentials m_credentials;

	public ICredentials Credentials { get; }


	public void .ctor() { }

	public Uri GetProxy(Uri uri) { }

	public bool IsBypassed(Uri uri) { }

	public ICredentials get_Credentials() { }

}

