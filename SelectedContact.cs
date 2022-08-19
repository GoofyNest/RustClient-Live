public class SelectedContact : SingletonComponent<SelectedContact> // TypeDefIndex: 10969
{	// Fields
	public RustText nameText; // 0x18
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

	// Methods

	// RVA: 0x4A8010 Offset: 0x4A7410 VA: 0x1804A8010
	public void SetSelected_Internal(RelationshipManager.PlayerRelationshipInfo selected) { }

	// RVA: 0x4A8680 Offset: 0x4A7A80 VA: 0x1804A8680
	public void Update() { }

	// RVA: 0x4A8580 Offset: 0x4A7980 VA: 0x1804A8580
	public void SetVisible(bool wantsVis) { }

	// RVA: 0x4A8500 Offset: 0x4A7900 VA: 0x1804A8500
	public static void SetSelected(RelationshipManager.PlayerRelationshipInfo selected) { }

	// RVA: 0x4A7E20 Offset: 0x4A7220 VA: 0x1804A7E20
	public void OnNoteTextChanged() { }

	// RVA: 0x4A8000 Offset: 0x4A7400 VA: 0x1804A8000
	public bool SelectedValid() { }

	// RVA: 0x4A7CD0 Offset: 0x4A70D0 VA: 0x1804A7CD0
	public void MakeAlly() { }

	// RVA: 0x4A7DB0 Offset: 0x4A71B0 VA: 0x1804A7DB0
	public void MakeSeen() { }

	// RVA: 0x4A7D40 Offset: 0x4A7140 VA: 0x1804A7D40
	public void MakeEnemy() { }

	// RVA: 0x4A7C60 Offset: 0x4A7060 VA: 0x1804A7C60
	public void Forget() { }

	// RVA: 0x4A85E0 Offset: 0x4A79E0 VA: 0x1804A85E0
	public void ToggleMute(bool state) { }

	// RVA: 0x4A7F40 Offset: 0x4A7340 VA: 0x1804A7F40
	public void ReportPlayer() { }

	// RVA: 0x4A8810 Offset: 0x4A7C10 VA: 0x1804A8810
	public void .ctor() { }

}

