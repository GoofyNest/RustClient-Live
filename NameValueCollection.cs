public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 3106
{	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }


	public void .ctor() { }

	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	internal void .ctor(DBNull dummy) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	protected void InvalidateCachedArrays() { }

	private static string GetAsOneString(ArrayList list) { }

	private static string[] GetAsStringArray(ArrayList list) { }

	public virtual void Add(string name, string value) { }

	public virtual string Get(string name) { }

	public virtual string[] GetValues(string name) { }

	public virtual void Set(string name, string value) { }

	public virtual void Remove(string name) { }

	public string get_Item(string name) { }

	public void set_Item(string name, string value) { }

	public virtual string Get(int index) { }

	public virtual string[] GetValues(int index) { }

	public virtual string GetKey(int index) { }

	public string get_Item(int index) { }

	public virtual string[] get_AllKeys() { }

}

