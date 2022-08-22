public class DoorAnimEvents : MonoBehaviour, IClientComponent // TypeDefIndex: 9324
{	public GameObjectRef openStart; // 0x18
	public GameObjectRef openEnd; // 0x20
	public GameObjectRef closeStart; // 0x28
	public GameObjectRef closeEnd; // 0x30
	public GameObject soundTarget; // 0x38
	public bool checkAnimSpeed; // 0x40

	public Animator animator { get; }


	public Animator get_animator() { }

	private void DoorOpenStart() { }

	private void DoorOpenEnd() { }

	private void DoorCloseStart() { }

	private void DoorCloseEnd() { }

	public void .ctor() { }

}

