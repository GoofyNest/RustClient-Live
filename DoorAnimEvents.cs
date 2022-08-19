public class DoorAnimEvents : MonoBehaviour, IClientComponent // TypeDefIndex: 9324
{	// Fields
	public GameObjectRef openStart; // 0x18
	public GameObjectRef openEnd; // 0x20
	public GameObjectRef closeStart; // 0x28
	public GameObjectRef closeEnd; // 0x30
	public GameObject soundTarget; // 0x38
	public bool checkAnimSpeed; // 0x40

	// Properties
	public Animator animator { get; }

	// Methods

	// RVA: 0xAA7770 Offset: 0xAA6B70 VA: 0x180AA7770
	public Animator get_animator() { }

	// RVA: 0xAA7530 Offset: 0xAA6930 VA: 0x180AA7530
	private void DoorOpenStart() { }

	// RVA: 0xAA72F0 Offset: 0xAA66F0 VA: 0x180AA72F0
	private void DoorOpenEnd() { }

	// RVA: 0xAA70B0 Offset: 0xAA64B0 VA: 0x180AA70B0
	private void DoorCloseStart() { }

	// RVA: 0xAA6E70 Offset: 0xAA6270 VA: 0x180AA6E70
	private void DoorCloseEnd() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

