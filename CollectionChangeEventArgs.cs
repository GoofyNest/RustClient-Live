public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 2674
{	// Fields
	private CollectionChangeAction action; // 0x10
	private object element; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x1599880 Offset: 0x1598C80 VA: 0x181599880
	public void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public virtual object get_Element() { }

}

