internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 3077
{
	public override string DomainName { get; }


	private static extern int getdomainname(byte[] name, int len) { }

	public override string get_DomainName() { }

	protected void .ctor() { }

}

