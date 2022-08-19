public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 495
{	// Fields
	private BinaryReader _store; // 0x10
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

	// Methods

	// RVA: 0xFEE0A0 Offset: 0xFED4A0 VA: 0x180FEE0A0
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0xFEA8D0 Offset: 0xFE9CD0 VA: 0x180FEA8D0 Slot: 4
	public void Close() { }

	// RVA: 0xFEAFC0 Offset: 0xFEA3C0 VA: 0x180FEAFC0 Slot: 7
	public void Dispose() { }

	// RVA: 0xFEAF00 Offset: 0xFEA300 VA: 0x180FEAF00
	private void Dispose(bool disposing) { }

	// RVA: 0xFEC430 Offset: 0xFEB830 VA: 0x180FEC430
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0xFEC450 Offset: 0xFEB850 VA: 0x180FEC450
	private void SkipString() { }

	// RVA: 0xFEB950 Offset: 0xFEAD50 VA: 0x180FEB950
	private int GetNameHash(int index) { }

	// RVA: 0xFEB9C0 Offset: 0xFEADC0 VA: 0x180FEB9C0
	private int GetNamePosition(int index) { }

	// RVA: 0xFEB890 Offset: 0xFEAC90 VA: 0x180FEB890 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFEB890 Offset: 0xFEAC90 VA: 0x180FEB890 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFEB820 Offset: 0xFEAC20 VA: 0x180FEB820
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0xFEAFD0 Offset: 0xFEA3D0 VA: 0x180FEAFD0
	internal int FindPosForResource(string name) { }

	// RVA: 0xFEA990 Offset: 0xFE9D90 VA: 0x180FEA990
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0xFEA140 Offset: 0xFE9540 VA: 0x180FEA140
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0xFEBB00 Offset: 0xFEAF00 VA: 0x180FEBB00
	private object GetValueForNameIndex(int index) { }

	// RVA: 0xFEC030 Offset: 0xFEB430 VA: 0x180FEC030
	internal string LoadString(int pos) { }

	// RVA: 0xFEBF60 Offset: 0xFEB360 VA: 0x180FEBF60
	internal object LoadObject(int pos) { }

	// RVA: 0xFEBF90 Offset: 0xFEB390 VA: 0x180FEBF90
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFEBD90 Offset: 0xFEB190 VA: 0x180FEBD90
	internal object LoadObjectV1(int pos) { }

	// RVA: 0xFEC520 Offset: 0xFEB920 VA: 0x180FEC520
	private object _LoadObjectV1(int pos) { }

	// RVA: 0xFEBE70 Offset: 0xFEB270 VA: 0x180FEBE70
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFECD20 Offset: 0xFEC120 VA: 0x180FECD20
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFEAD40 Offset: 0xFEA140 VA: 0x180FEAD40
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0xFEC300 Offset: 0xFEB700 VA: 0x180FEC300
	private void ReadResources() { }

	// RVA: 0xFED740 Offset: 0xFECB40 VA: 0x180FED740
	private void _ReadResources() { }

	// RVA: 0xFEB400 Offset: 0xFEA800 VA: 0x180FEB400
	private RuntimeType FindType(int typeIndex) { }

}

internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 496
{	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0xFE6D00 Offset: 0xFE6100 VA: 0x180FE6D00
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0xFE6C10 Offset: 0xFE6010 VA: 0x180FE6C10 Slot: 7
	public bool MoveNext() { }

	// RVA: 0xFE7140 Offset: 0xFE6540 VA: 0x180FE7140 Slot: 4
	public object get_Key() { }

	// RVA: 0xFE6D40 Offset: 0xFE6140 VA: 0x180FE6D40 Slot: 8
	public object get_Current() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_DataPosition() { }

	// RVA: 0xFE6DA0 Offset: 0xFE61A0 VA: 0x180FE6DA0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFE7270 Offset: 0xFE6670 VA: 0x180FE7270 Slot: 5
	public object get_Value() { }

	// RVA: 0xFE6C60 Offset: 0xFE6060 VA: 0x180FE6C60 Slot: 9
	public void Reset() { }

}

