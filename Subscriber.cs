public class Subscriber : Pool.IPooled // TypeDefIndex: 6881
{
	internal Manager manager; 
	internal Connection connection; 
	public ListHashSet<Group> subscribed; 


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

