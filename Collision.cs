public class Collision // TypeDefIndex: 3915
{
	internal Vector3 m_Impulse; 
	internal Vector3 m_RelativeVelocity; 
	internal Rigidbody m_Rigidbody; 
	internal Collider m_Collider; 
	internal int m_ContactCount; 
	internal ContactPoint[] m_ReusedContacts; 
	internal ContactPoint[] m_LegacyContacts; 

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

