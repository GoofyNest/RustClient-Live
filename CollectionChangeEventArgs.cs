public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 2674
{	private CollectionChangeAction action; // 0x10
	private object element; // 0x18

	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }


	public void .ctor(CollectionChangeAction action, object element) { }

	public virtual CollectionChangeAction get_Action() { }

	public virtual object get_Element() { }

}

