internal sealed class NameInfo // TypeDefIndex: 1124
{
	internal string NIFullName;
	internal long NIobjectId;
	internal long NIassemId;
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum;
	internal Type NItype;
	internal bool NIisSealed;
	internal bool NIisArray;
	internal bool NIisArrayItem;
	internal bool NItransmitTypeOnObject;
	internal bool NItransmitTypeOnMember;
	internal bool NIisParentTypeOnObject;
	internal InternalArrayTypeE NIarrayEnum;
	private bool NIsealedStatusChecked;

	public bool IsSealed { get; }
	public string NIname { get; set; }


	internal void .ctor() { }

	internal void Init() { }

	public bool get_IsSealed() { }

	public string get_NIname() { }

	public void set_NIname(string value) { }

}

internal sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo> // TypeDefIndex: 1525
{
	private static int lastIdentity;
	internal readonly string name;
	internal readonly EventTags tags;
	internal readonly int identity;
	internal readonly byte[] nameMetadata;


	internal static void ReserveEventIDsBelow(int eventId) { }

	public void .ctor(string name, EventTags tags, int typeMetadataSize) { }

	public override int Compare(NameInfo other) { }

	public override int Compare(KeyValuePair<string, EventTags> key) { }

	private int Compare(string otherName, EventTags otherTags) { }

	private static void .cctor() { }

}

