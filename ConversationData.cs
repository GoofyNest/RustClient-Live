public class ConversationData : ScriptableObject // TypeDefIndex: 8840
{	public string shortname; // 0x18
	public Translate.Phrase providerNameTranslated; // 0x20
	public ConversationData.SpeechNode[] speeches; // 0x28

	public string providerName { get; }


	public string get_providerName() { }

	public int GetSpeechNodeIndex(string speechShortName) { }

	public void .ctor() { }

}

public class ConversationData.ConversationCondition // TypeDefIndex: 8841
{	public ConversationData.ConversationCondition.ConditionType conditionType; // 0x10
	public uint conditionAmount; // 0x14
	public bool inverse; // 0x18
	public string failedSpeechNode; // 0x20


	public bool Passes(BasePlayer player, IConversationProvider provider) { }

	public void .ctor() { }

}

public enum ConversationData.ConversationCondition.ConditionType // TypeDefIndex: 8842
{	public int value__; // 0x0
	public const ConversationData.ConversationCondition.ConditionType NONE = 0;
	public const ConversationData.ConversationCondition.ConditionType HASHEALTH = 1;
	public const ConversationData.ConversationCondition.ConditionType HASSCRAP = 2;
	public const ConversationData.ConversationCondition.ConditionType PROVIDERBUSY = 3;
	public const ConversationData.ConversationCondition.ConditionType MISSIONCOMPLETE = 4;
	public const ConversationData.ConversationCondition.ConditionType MISSIONATTEMPTED = 5;
	public const ConversationData.ConversationCondition.ConditionType CANACCEPT = 6;

}

public class ConversationData.ResponseNode // TypeDefIndex: 8843
{	public Translate.Phrase responseTextLocalized; // 0x10
	public ConversationData.ConversationCondition[] conditions; // 0x18
	public string actionString; // 0x20
	public string resultingSpeechNode; // 0x28

	public string responseText { get; }


	public string get_responseText() { }

	public bool PassesConditions(BasePlayer player, IConversationProvider provider) { }

	public string GetFailedSpeechNode(BasePlayer player, IConversationProvider provider) { }

	public void .ctor() { }

}

public class ConversationData.SpeechNode // TypeDefIndex: 8844
{	public string shortname; // 0x10
	public Translate.Phrase statementLocalized; // 0x18
	public ConversationData.ResponseNode[] responses; // 0x20
	public Vector2 nodePosition; // 0x28

	public string statement { get; }


	public string get_statement() { }

	public void .ctor() { }

}

