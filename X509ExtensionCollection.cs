internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 62
{
	private bool readOnly; 


public void .ctor() { }

public void .ctor(ASN1 asn1) { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1720
{
	private bool readOnly; 

public X509Extension Item { get; }


public void .ctor() { }

public void .ctor(ASN1 asn1) { }

public int IndexOf(string oid) { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

public X509Extension get_Item(string oid) { }

}

public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 2832
{
	private static byte[] Empty; 
	private ArrayList _list; 

public int Count { get; }
public object SyncRoot { get; }
public X509Extension Item { get; }


internal void .ctor(X509Certificate cert) { }

public int get_Count() { }

public object get_SyncRoot() { }

public X509Extension get_Item(string oid) { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

public X509ExtensionEnumerator GetEnumerator() { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

private static void .cctor() { }

}

