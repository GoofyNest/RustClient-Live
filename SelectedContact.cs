public class SelectedContact : SingletonComponent<SelectedContact> // TypeDefIndex: 12746
{
	public RustText nameText;
	public RustText seenText;
	public RawImage mugshotImage;
	public Texture2D unknownMugshot;
	public InputField noteInput;
	public GameObject[] relationshipTypeTags;
	public Translate.Phrase lastSeenPrefix;
	public Translate.Phrase nowPhrase;
	public Translate.Phrase agoSuffix;
	public RustButton FriendlyButton;
	public RustButton SeenButton;
	public RustButton EnemyButton;
	public RustButton chatMute;
	private ulong selectedPlayerId;
	private RelationshipManager.RelationshipType selectedPlayerRelationship;


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

