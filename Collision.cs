public class Collision // TypeDefIndex: 3915
{	internal Vector3 m_Impulse; // 0x10
	internal Vector3 m_RelativeVelocity; // 0x1C
	internal Rigidbody m_Rigidbody; // 0x28
	internal Collider m_Collider; // 0x30
	internal int m_ContactCount; // 0x38
	internal ContactPoint[] m_ReusedContacts; // 0x40
	internal ContactPoint[] m_LegacyContacts; // 0x48

	public Rigidbody rigidbody { get; }
	public Collider collider { get; }
	public Transform transform { get; }
	public int contactCount { get; }


	private ContactPoint[] GetContacts_Internal() { }

	public Rigidbody get_rigidbody() { }

	public Collider get_collider() { }

	public Transform get_transform() { }

	public int get_contactCount() { }

	public ContactPoint GetContact(int index) { }

}

