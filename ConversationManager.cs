public class ConversationManager : MonoBehaviour // TypeDefIndex: 8846
{	// Fields
	private static ConversationManager.Conversation activeConversation; // 0x163C

	// Methods

	// RVA: 0x516530 Offset: 0x515930 VA: 0x180516530
	public static bool InConversation() { }

	// RVA: 0x5164F0 Offset: 0x5158F0 VA: 0x1805164F0
	public static ConversationManager.Conversation GetActiveConversation() { }

	// RVA: 0x5163F0 Offset: 0x5157F0 VA: 0x1805163F0
	public static void FastForward() { }

	// RVA: 0x5165A0 Offset: 0x5159A0 VA: 0x1805165A0
	public static void ModifyCamera() { }

	// RVA: 0x5168D0 Offset: 0x515CD0 VA: 0x1805168D0
	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro") { }

	// RVA: 0x516240 Offset: 0x515640 VA: 0x180516240
	public static void CancelConversation(bool fromServer) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ConversationManager.Conversation : MonoBehaviour // TypeDefIndex: 8847
{	// Fields
	public ConversationData data; // 0x18
	public int currentSpeechNodeIndex; // 0x20
	public IConversationProvider provider; // 0x28
	private float age; // 0x30
	private float speechNodeAge; // 0x34
	private int speechCharacterIndex; // 0x38
	private float timeOnChar; // 0x3C

	// Methods

	// RVA: 0x516B80 Offset: 0x515F80 VA: 0x180516B80
	public int GetSpeechNodeIndex(string name) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public int GetSpeechCharacterIndex() { }

	// RVA: 0x516CA0 Offset: 0x5160A0 VA: 0x180516CA0
	public bool IsTalking() { }

	// RVA: 0x516DD0 Offset: 0x5161D0 VA: 0x180516DD0
	public void SwitchToSpeechNode(int index) { }

	// RVA: 0x516D20 Offset: 0x516120 VA: 0x180516D20
	public void ResponsePressed(int index) { }

	// RVA: 0x516B60 Offset: 0x515F60 VA: 0x180516B60
	public float GetConversationAge() { }

	// RVA: 0x516C90 Offset: 0x516090 VA: 0x180516C90
	public bool HasConversationStarted() { }

	// RVA: 0x516FC0 Offset: 0x5163C0 VA: 0x180516FC0
	public void Update() { }

	// RVA: 0x516AF0 Offset: 0x515EF0 VA: 0x180516AF0
	public void FastFowardSpeech() { }

	// RVA: 0x516DE0 Offset: 0x5161E0 VA: 0x180516DE0
	public void UpdateSpeechCharacterIndex(float delta) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

