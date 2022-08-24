internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 499
{
internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; 
	private ResourceReader _defaultReader; 
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; 
	private bool _haveReadFromReader; 


internal void .ctor(string fileName) { }

internal void .ctor(Stream stream) { }

protected override void Dispose(bool disposing) { }

public override IDictionaryEnumerator GetEnumerator() { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

private IDictionaryEnumerator GetEnumeratorHelper() { }

public override string GetString(string key) { }

public override string GetString(string key, bool ignoreCase) { }

public override object GetObject(string key) { }

public override object GetObject(string key, bool ignoreCase) { }

private object GetObject(string key, bool ignoreCase, bool isString) { }

private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

}

