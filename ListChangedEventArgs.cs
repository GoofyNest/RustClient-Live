public class ListChangedEventArgs : EventArgs // TypeDefIndex: 2725
{
	private ListChangedType listChangedType; 
	private int newIndex; 
	private int oldIndex; 
	private PropertyDescriptor propDesc; 

	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }


	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	public ListChangedType get_ListChangedType() { }

	public int get_NewIndex() { }

	public int get_OldIndex() { }

}

