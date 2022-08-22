internal sealed class NameInfo // TypeDefIndex: 1124
{	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	public bool IsSealed { get; }
	public string NIname { get; set; }


	internal void .ctor() { }

	internal void Init() { }

	public bool get_IsSealed() { }

	public string get_NIname() { }

	public void set_NIname(string value) { }

}

internal sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo> // TypeDefIndex: 1525
{	private static int lastIdentity; // 0x0
	internal readonly string name; // 0x10
	internal readonly EventTags tags; // 0x18
	internal readonly int identity; // 0x1C
	internal readonly byte[] nameMetadata; // 0x20


	internal static void ReserveEventIDsBelow(int eventId) { }

	public void .ctor(string name, EventTags tags, int typeMetadataSize) { }

	public override int Compare(NameInfo other) { }

	public override int Compare(KeyValuePair<string, EventTags> key) { }

	private int Compare(string otherName, EventTags otherTags) { }

	private static void .cctor() { }

}

