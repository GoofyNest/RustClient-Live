public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 497
{
	protected IResourceReader Reader; 
	protected Hashtable Table; 
	private Hashtable _caseInsensitiveTable; 


	protected void .ctor() { }

	internal void .ctor(bool junk) { }

	private void CommonInit() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	[ComVisibleAttribute] 
	public virtual IDictionaryEnumerator GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private IDictionaryEnumerator GetEnumeratorHelper() { }

	public virtual string GetString(string name) { }

	public virtual string GetString(string name, bool ignoreCase) { }

	public virtual object GetObject(string name) { }

	public virtual object GetObject(string name, bool ignoreCase) { }

	private object GetObjectInternal(string name) { }

	private object GetCaseInsensitiveObjectInternal(string name) { }

}

