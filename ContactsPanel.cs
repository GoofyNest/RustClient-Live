public class ContactsPanel : SingletonComponent<ContactsPanel> // TypeDefIndex: 12700
{
	public RectTransform alliesBucket; 
	public RectTransform seenBucket; 
	public RectTransform enemiesBucket; 
	public RectTransform contentsBucket; 
	public ContactsEntry contactEntryPrefab; 
	public RawImage mugshotTest; 
	public RawImage fullBodyTest; 
	public RustButton[] filterButtons; 
	public RelationshipManager.RelationshipType selectedRelationshipType; 
	public RustButton lastSeenToggle; 
	public Translate.Phrase sortingByLastSeenPhrase; 
	public Translate.Phrase sortingByFirstSeen; 
	public RustText sortText; 
	private ContactsPanel.SortMode sortMode; 
	private ulong selectedPlayerID; 
	private float nextUpdateTime; 
	private bool dirty; 


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

public enum ContactsPanel.SortMode // TypeDefIndex: 12701
{
	public int value__; 
	public const ContactsPanel.SortMode None = 0;
	public const ContactsPanel.SortMode RecentlySeen = 1;

}

