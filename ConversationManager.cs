public class ConversationManager : MonoBehaviour // TypeDefIndex: 8846
{	private static ConversationManager.Conversation activeConversation; // 0x163C


	public static bool InConversation() { }

	public static ConversationManager.Conversation GetActiveConversation() { }

	public static void FastForward() { }

	public static void ModifyCamera() { }

	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro") { }

	public static void CancelConversation(bool fromServer) { }

	public void .ctor() { }

}

public class ConversationManager.Conversation : MonoBehaviour // TypeDefIndex: 8847
{	public ConversationData data; // 0x18
	public int currentSpeechNodeIndex; // 0x20
	public IConversationProvider provider; // 0x28
	private float age; // 0x30
	private float speechNodeAge; // 0x34
	private int speechCharacterIndex; // 0x38
	private float timeOnChar; // 0x3C


	public int GetSpeechNodeIndex(string name) { }

	public int GetSpeechCharacterIndex() { }

	public bool IsTalking() { }

	public void SwitchToSpeechNode(int index) { }

	public void ResponsePressed(int index) { }

	public float GetConversationAge() { }

	public bool HasConversationStarted() { }

	public void Update() { }

	public void FastFowardSpeech() { }

	public void UpdateSpeechCharacterIndex(float delta) { }

	public void .ctor() { }

}

