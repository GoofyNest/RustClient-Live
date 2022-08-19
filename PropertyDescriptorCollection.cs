public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 2735
{	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary cachedFoundProperties; // 0x10
	private bool cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] properties; // 0x20
	private int propCount; // 0x28
	private string[] namedSort; // 0x30
	private IComparer comparer; // 0x38
	private bool propsOwned; // 0x40
	private bool needSort; // 0x41
	private bool readOnly; // 0x42

	// Properties
	public int Count { get; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x15ACBE0 Offset: 0x15ABFE0 VA: 0x1815ACBE0
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x15ACC80 Offset: 0x15AC080 VA: 0x1815ACC80
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x15ACB00 Offset: 0x15ABF00 VA: 0x1815ACB00
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_Count() { }

	// RVA: 0x15ACD50 Offset: 0x15AC150 VA: 0x1815ACD50 Slot: 29
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x15ACD30 Offset: 0x15AC130 VA: 0x1815ACD30 Slot: 30
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x15AA870 Offset: 0x15A9C70 VA: 0x1815AA870
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x15AA970 Offset: 0x15A9D70 VA: 0x1815AA970
	public void Clear() { }

	// RVA: 0x15AA9E0 Offset: 0x15A9DE0 VA: 0x1815AA9E0
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x15AAA40 Offset: 0x15A9E40 VA: 0x1815AAA40 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15AAA90 Offset: 0x15A9E90 VA: 0x1815AAA90
	private void EnsurePropsOwned() { }

	// RVA: 0x15AAB40 Offset: 0x15A9F40 VA: 0x1815AAB40
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x15AAC60 Offset: 0x15AA060 VA: 0x1815AAC60 Slot: 31
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x15AB150 Offset: 0x15AA550 VA: 0x1815AB150
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x15AB1B0 Offset: 0x15AA5B0 VA: 0x1815AB1B0
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x15AB840 Offset: 0x15AAC40 VA: 0x1815AB840
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x15AB760 Offset: 0x15AAB60 VA: 0x1815AB760
	public void RemoveAt(int index) { }

	// RVA: 0x15AB900 Offset: 0x15AAD00 VA: 0x1815AB900 Slot: 32
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x15AB350 Offset: 0x15AA750 VA: 0x1815AB350
	protected void InternalSort(string[] names) { }

	// RVA: 0x15AB2D0 Offset: 0x15AA6D0 VA: 0x1815AB2D0
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x15AB0A0 Offset: 0x15AA4A0 VA: 0x1815AB0A0 Slot: 33
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15ABA10 Offset: 0x15AAE10 VA: 0x1815ABA10 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x15AA970 Offset: 0x15A9D70 VA: 0x1815AA970 Slot: 25
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x15ABAC0 Offset: 0x15AAEC0 VA: 0x1815ABAC0 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x15ABB60 Offset: 0x15AAF60 VA: 0x1815ABB60 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0xEE1EC0 Offset: 0xEE12C0 VA: 0x180EE1EC0 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x15ABC70 Offset: 0x15AB070 VA: 0x1815ABC70 Slot: 19
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x15ABEE0 Offset: 0x15AB2E0 VA: 0x1815ABEE0 Slot: 20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x15ABD00 Offset: 0x15AB100 VA: 0x1815ABD00 Slot: 21
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x15ABE20 Offset: 0x15AB220 VA: 0x1815ABE20 Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x15ABBD0 Offset: 0x15AAFD0 VA: 0x1815ABBD0 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x15AC2D0 Offset: 0x15AB6D0 VA: 0x1815AC2D0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15AC2F0 Offset: 0x15AB6F0 VA: 0x1815AC2F0 Slot: 10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x15AA970 Offset: 0x15A9D70 VA: 0x1815AA970 Slot: 12
	private void System.Collections.IList.Clear() { }

	// RVA: 0x15AC380 Offset: 0x15AB780 VA: 0x1815AC380 Slot: 11
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x15AC450 Offset: 0x15AB850 VA: 0x1815AC450 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x15AC520 Offset: 0x15AB920 VA: 0x1815AC520 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xEE1EC0 Offset: 0xEE12C0 VA: 0x180EE1EC0 Slot: 13
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xEE1EC0 Offset: 0xEE12C0 VA: 0x180EE1EC0 Slot: 14
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x15AC6C0 Offset: 0x15ABAC0 VA: 0x1815AC6C0 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x15AC6B0 Offset: 0x15ABAB0 VA: 0x1815AC6B0 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x15AC7F0 Offset: 0x15ABBF0 VA: 0x1815AC7F0 Slot: 8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x15AC810 Offset: 0x15ABC10 VA: 0x1815AC810 Slot: 9
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x15ACA40 Offset: 0x15ABE40 VA: 0x1815ACA40
	private static void .cctor() { }

}

private class PropertyDescriptorCollection.PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2736
{	// Fields
	private PropertyDescriptorCollection owner; // 0x10
	private int index; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x11B44A0 Offset: 0x11B38A0 VA: 0x1811B44A0
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x15ACE30 Offset: 0x15AC230 VA: 0x1815ACE30 Slot: 8
	public object get_Current() { }

	// RVA: 0x15ACED0 Offset: 0x15AC2D0 VA: 0x1815ACED0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x15ACF40 Offset: 0x15AC340 VA: 0x1815ACF40 Slot: 4
	public object get_Key() { }

	// RVA: 0x15ACF40 Offset: 0x15AC340 VA: 0x1815ACF40 Slot: 5
	public object get_Value() { }

	// RVA: 0x15ACDF0 Offset: 0x15AC1F0 VA: 0x1815ACDF0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1176E50 Offset: 0x1176250 VA: 0x181176E50 Slot: 9
	public void Reset() { }

}

