public class Subscriber : Pool.IPooled // TypeDefIndex: 6707
{	internal Manager manager; // 0x10
	internal Connection connection; // 0x18
	public ListHashSet<Group> subscribed; // 0x20


	public Group Subscribe(Group group) { }

	public Group Subscribe(uint group) { }

	public bool IsSubscribed(Group group) { }

	public void UnsubscribeAll() { }

	public void Unsubscribe(Group group) { }

	public void Destroy() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

