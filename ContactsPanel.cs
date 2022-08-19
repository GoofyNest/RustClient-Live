public class ContactsPanel : SingletonComponent<ContactsPanel> // TypeDefIndex: 10938
{	// Fields
	public RectTransform alliesBucket; // 0x18
	public RectTransform seenBucket; // 0x20
	public RectTransform enemiesBucket; // 0x28
	public RectTransform contentsBucket; // 0x30
	public ContactsEntry contactEntryPrefab; // 0x38
	public RawImage mugshotTest; // 0x40
	public RawImage fullBodyTest; // 0x48
	public RustButton[] filterButtons; // 0x50
	public RelationshipManager.RelationshipType selectedRelationshipType; // 0x58
	public RustButton lastSeenToggle; // 0x60
	public Translate.Phrase sortingByLastSeenPhrase; // 0x68
	public Translate.Phrase sortingByFirstSeen; // 0x70
	public RustText sortText; // 0x78
	private ContactsPanel.SortMode sortMode; // 0x80
	private ulong selectedPlayerID; // 0x88
	private float nextUpdateTime; // 0x90
	private bool dirty; // 0x94

	// Methods

	// RVA: 0x5126D0 Offset: 0x511AD0 VA: 0x1805126D0
	public RectTransform BucketFromType(RelationshipManager.RelationshipType type) { }

	// RVA: 0x512D20 Offset: 0x512120 VA: 0x180512D20
	public void Repopulate() { }

	// RVA: 0x513510 Offset: 0x512910 VA: 0x180513510
	public void SelectRelationshipType(int type) { }

	// RVA: 0x512B20 Offset: 0x511F20 VA: 0x180512B20
	public static RelationshipManager.PlayerRelationshipInfo GetSelectedContact() { }

	// RVA: 0x512A40 Offset: 0x511E40 VA: 0x180512A40
	public void DeselectContact(ContactsEntry deselected) { }

	// RVA: 0x512A50 Offset: 0x511E50 VA: 0x180512A50
	public static void DeselectContact() { }

	// RVA: 0x5127B0 Offset: 0x511BB0 VA: 0x1805127B0
	public void ContactClicked(ContactsEntry selected) { }

	// RVA: 0x5137A0 Offset: 0x512BA0 VA: 0x1805137A0
	private bool WantsUpdate() { }

	// RVA: 0x5136F0 Offset: 0x512AF0 VA: 0x1805136F0
	public void Update() { }

	// RVA: 0x4C46B0 Offset: 0x4C3AB0 VA: 0x1804C46B0
	public void MarkDirty() { }

	// RVA: 0x512CB0 Offset: 0x5120B0 VA: 0x180512CB0
	public static void ReceivedNewContacts() { }

	// RVA: 0x5126C0 Offset: 0x511AC0 VA: 0x1805126C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x512770 Offset: 0x511B70 VA: 0x180512770
	private static int CompareRecentlySeen(RelationshipManager.PlayerRelationshipInfo a, RelationshipManager.PlayerRelationshipInfo b) { }

	// RVA: 0x5135C0 Offset: 0x5129C0 VA: 0x1805135C0
	public void SetSortOff() { }

	// RVA: 0x513630 Offset: 0x512A30 VA: 0x180513630
	public void SetSortOn() { }

	// RVA: 0x512700 Offset: 0x511B00 VA: 0x180512700
	private void ChangeSortMode(ContactsPanel.SortMode newMode) { }

	// RVA: 0x5136A0 Offset: 0x512AA0 VA: 0x1805136A0
	private void UpdateSortText() { }

	// RVA: 0x5137D0 Offset: 0x512BD0 VA: 0x1805137D0
	public void .ctor() { }

}

public enum ContactsPanel.SortMode // TypeDefIndex: 10939
{	// Fields
	public int value__; // 0x0
	public const ContactsPanel.SortMode None = 0;
	public const ContactsPanel.SortMode RecentlySeen = 1;

}

