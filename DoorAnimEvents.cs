public class DoorAnimEvents : MonoBehaviour, IClientComponent // TypeDefIndex: 11059
{
	public GameObjectRef openStart; 
	public GameObjectRef openEnd; 
	public GameObjectRef closeStart; 
	public GameObjectRef closeEnd; 
	public GameObject soundTarget; 
	public bool checkAnimSpeed; 

	public Animator animator { get; }


	public Animator get_animator() { }

	private void DoorOpenStart() { }

	private void DoorOpenEnd() { }

	private void DoorCloseStart() { }

	private void DoorCloseEnd() { }

	public void .ctor() { }

}

