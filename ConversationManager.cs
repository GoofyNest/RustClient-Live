public class ConversationManager : MonoBehaviour // TypeDefIndex: 10562
{
	private static ConversationManager.Conversation activeConversation; 


	public static bool InConversation() { }

	public static ConversationManager.Conversation GetActiveConversation() { }

	public static void FastForward() { }

	public static void ModifyCamera() { }

	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro") { }

	public static void CancelConversation(bool fromServer) { }

	public void .ctor() { }

}

public class ConversationManager.Conversation : MonoBehaviour // TypeDefIndex: 10563
{
	public ConversationData data; 
	public int currentSpeechNodeIndex; 
	public IConversationProvider provider; 
	private float age; 
	private float speechNodeAge; 
	private int speechCharacterIndex; 
	private float timeOnChar; 


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

