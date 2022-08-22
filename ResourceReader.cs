public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 495
{	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78


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
{	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

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

