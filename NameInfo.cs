internal sealed class NameInfo // TypeDefIndex: 1124
{	// Fields
	internal string NIFullName; // 0x10
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

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11F0B70 Offset: 0x11EFF70 VA: 0x1811F0B70
	internal void Init() { }

	// RVA: 0x11F0BD0 Offset: 0x11EFFD0 VA: 0x1811F0BD0
	public bool get_IsSealed() { }

	// RVA: 0x11F0C10 Offset: 0x11F0010 VA: 0x1811F0C10
	public string get_NIname() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_NIname(string value) { }

}

internal sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo> // TypeDefIndex: 1525
{	// Fields
	private static int lastIdentity; // 0x0
	internal readonly string name; // 0x10
	internal readonly EventTags tags; // 0x18
	internal readonly int identity; // 0x1C
	internal readonly byte[] nameMetadata; // 0x20

	// Methods

	// RVA: 0x10DF3C0 Offset: 0x10DE7C0 VA: 0x1810DF3C0
	internal static void ReserveEventIDsBelow(int eventId) { }

	// RVA: 0x10DF4D0 Offset: 0x10DE8D0 VA: 0x1810DF4D0
	public void .ctor(string name, EventTags tags, int typeMetadataSize) { }

	// RVA: 0x10DF340 Offset: 0x10DE740 VA: 0x1810DF340 Slot: 4
	public override int Compare(NameInfo other) { }

	// RVA: 0x10DF370 Offset: 0x10DE770 VA: 0x1810DF370 Slot: 5
	public override int Compare(KeyValuePair<string, EventTags> key) { }

	// RVA: 0x10DF240 Offset: 0x10DE640 VA: 0x1810DF240
	private int Compare(string otherName, EventTags otherTags) { }

	// RVA: 0x10DF490 Offset: 0x10DE890 VA: 0x1810DF490
	private static void .cctor() { }

}

