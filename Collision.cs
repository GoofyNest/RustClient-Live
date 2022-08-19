public class Collision // TypeDefIndex: 3915
{	// Fields
	internal Vector3 m_Impulse; // 0x10
	internal Vector3 m_RelativeVelocity; // 0x1C
	internal Rigidbody m_Rigidbody; // 0x28
	internal Collider m_Collider; // 0x30
	internal int m_ContactCount; // 0x38
	internal ContactPoint[] m_ReusedContacts; // 0x40
	internal ContactPoint[] m_LegacyContacts; // 0x48

	// Properties
	public Rigidbody rigidbody { get; }
	public Collider collider { get; }
	public Transform transform { get; }
	public int contactCount { get; }

	// Methods

	// RVA: 0x2292260 Offset: 0x2291660 VA: 0x182292260
	private ContactPoint[] GetContacts_Internal() { }

	// RVA: 0x1818760 Offset: 0x1817B60 VA: 0x181818760
	public Rigidbody get_rigidbody() { }

	// RVA: 0xEC9460 Offset: 0xEC8860 VA: 0x180EC9460
	public Collider get_collider() { }

	// RVA: 0x2292280 Offset: 0x2291680 VA: 0x182292280
	public Transform get_transform() { }

	// RVA: 0x2292270 Offset: 0x2291670 VA: 0x182292270
	public int get_contactCount() { }

	// RVA: 0x2292130 Offset: 0x2291530 VA: 0x182292130
	public ContactPoint GetContact(int index) { }

}

