public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 495
{
	private BinaryReader _store; 
	internal Dictionary<string, ResourceLocator> _resCache; 
	private long _nameSectionOffset; 
	private long _dataSectionOffset; 
	private int[] _nameHashes; 
	private int* _nameHashesPtr; 
	private int[] _namePositions; 
	private int* _namePositionsPtr; 
	private RuntimeType[] _typeTable; 
	private int[] _typeNamePositions; 
	private BinaryFormatter _objFormatter; 
	private int _numResources; 
	private UnmanagedMemoryStream _ums; 
	private int _version; 


internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

public void Close() { }

public void Dispose() { }

private void Dispose(bool disposing) { }

internal static int ReadUnalignedI4(int* p) { }

private void SkipString() { }

private int GetNameHash(int index) { }

private int GetNamePosition(int index) { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

public IDictionaryEnumerator GetEnumerator() { }

internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

internal int FindPosForResource(string name) { }

private bool CompareStringEqualsName(string name) { }

private string AllocateStringForNameIndex(int index, out int dataOffset) { }

private object GetValueForNameIndex(int index) { }

internal string LoadString(int pos) { }

internal object LoadObject(int pos) { }

internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

internal object LoadObjectV1(int pos) { }

private object _LoadObjectV1(int pos) { }

internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

private object DeserializeObject(int typeIndex) { }

private void ReadResources() { }

private void _ReadResources() { }

private RuntimeType FindType(int typeIndex) { }

}

internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 496
{
	private ResourceReader _reader; 
	private bool _currentIsValid; 
	private int _currentName; 
	private int _dataPosition; 

public object Key { get; }
public object Current { get; }
internal int DataPosition { get; }
public DictionaryEntry Entry { get; }
public object Value { get; }


internal void .ctor(ResourceReader reader) { }

public bool MoveNext() { }

public object get_Key() { }

public object get_Current() { }

internal int get_DataPosition() { }

public DictionaryEntry get_Entry() { }

public object get_Value() { }

public void Reset() { }

}

