public class ContactsPanel : SingletonComponent<ContactsPanel> // TypeDefIndex: 10938
{	public RectTransform alliesBucket; // 0x18
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


	public RectTransform BucketFromType(RelationshipManager.RelationshipType type) { }

	public void Repopulate() { }

	public void SelectRelationshipType(int type) { }

	public static RelationshipManager.PlayerRelationshipInfo GetSelectedContact() { }

	public void DeselectContact(ContactsEntry deselected) { }

	public static void DeselectContact() { }

	public void ContactClicked(ContactsEntry selected) { }

	private bool WantsUpdate() { }

	public void Update() { }

	public void MarkDirty() { }

	public static void ReceivedNewContacts() { }

	protected override void Awake() { }

	private static int CompareRecentlySeen(RelationshipManager.PlayerRelationshipInfo a, RelationshipManager.PlayerRelationshipInfo b) { }

	public void SetSortOff() { }

	public void SetSortOn() { }

	private void ChangeSortMode(ContactsPanel.SortMode newMode) { }

	private void UpdateSortText() { }

	public void .ctor() { }

}

public enum ContactsPanel.SortMode // TypeDefIndex: 10939
{	public int value__; // 0x0
	public const ContactsPanel.SortMode None = 0;
	public const ContactsPanel.SortMode RecentlySeen = 1;

}

