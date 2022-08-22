public class SelectedContact : SingletonComponent<SelectedContact> // TypeDefIndex: 10969
{	public RustText nameText; // 0x18
	public RustText seenText; // 0x20
	public RawImage mugshotImage; // 0x28
	public Texture2D unknownMugshot; // 0x30
	public InputField noteInput; // 0x38
	public GameObject[] relationshipTypeTags; // 0x40
	public Translate.Phrase lastSeenPrefix; // 0x48
	public Translate.Phrase nowPhrase; // 0x50
	public Translate.Phrase agoSuffix; // 0x58
	public RustButton FriendlyButton; // 0x60
	public RustButton SeenButton; // 0x68
	public RustButton EnemyButton; // 0x70
	public RustButton chatMute; // 0x78
	private ulong selectedPlayerId; // 0x80
	private RelationshipManager.RelationshipType selectedPlayerRelationship; // 0x88


	public void SetSelected_Internal(RelationshipManager.PlayerRelationshipInfo selected) { }

	public void Update() { }

	public void SetVisible(bool wantsVis) { }

	public static void SetSelected(RelationshipManager.PlayerRelationshipInfo selected) { }

	public void OnNoteTextChanged() { }

	public bool SelectedValid() { }

	public void MakeAlly() { }

	public void MakeSeen() { }

	public void MakeEnemy() { }

	public void Forget() { }

	public void ToggleMute(bool state) { }

	public void ReportPlayer() { }

	public void .ctor() { }

}

