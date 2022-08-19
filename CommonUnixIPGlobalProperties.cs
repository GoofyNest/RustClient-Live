internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 3077
{	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x132A640 Offset: 0x1329A40 VA: 0x18132A640
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x132A4D0 Offset: 0x13298D0 VA: 0x18132A4D0 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

