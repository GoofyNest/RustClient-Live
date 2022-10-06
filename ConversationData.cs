public class ConversationData : ScriptableObject // TypeDefIndex: 10548
{
	public string shortname; 
	public Translate.Phrase providerNameTranslated; 
	public ConversationData.SpeechNode[] speeches; 

	public string providerName { get; }


	public string get_providerName() { }

	public int GetSpeechNodeIndex(string speechShortName) { }

	public void .ctor() { }

}

public class ConversationData.ConversationCondition // TypeDefIndex: 10549
{
	public ConversationData.ConversationCondition.ConditionType conditionType; 
	public uint conditionAmount; 
	public bool inverse; 
	public string failedSpeechNode; 


	public bool Passes(BasePlayer player, IConversationProvider provider) { }

	public void .ctor() { }

}

public enum ConversationData.ConversationCondition.ConditionType // TypeDefIndex: 10550
{
	public int value__; 
	public const ConversationData.ConversationCondition.ConditionType NONE = 0;
	public const ConversationData.ConversationCondition.ConditionType HASHEALTH = 1;
	public const ConversationData.ConversationCondition.ConditionType HASSCRAP = 2;
	public const ConversationData.ConversationCondition.ConditionType PROVIDERBUSY = 3;
	public const ConversationData.ConversationCondition.ConditionType MISSIONCOMPLETE = 4;
	public const ConversationData.ConversationCondition.ConditionType MISSIONATTEMPTED = 5;
	public const ConversationData.ConversationCondition.ConditionType CANACCEPT = 6;

}

public class ConversationData.ResponseNode // TypeDefIndex: 10551
{
	public Translate.Phrase responseTextLocalized; 
	public ConversationData.ConversationCondition[] conditions; 
	public string actionString; 
	public string resultingSpeechNode; 

	public string responseText { get; }


	public string get_responseText() { }

	public bool PassesConditions(BasePlayer player, IConversationProvider provider) { }

	public string GetFailedSpeechNode(BasePlayer player, IConversationProvider provider) { }

	public void .ctor() { }

}

public class ConversationData.SpeechNode // TypeDefIndex: 10552
{
	public string shortname; 
	public Translate.Phrase statementLocalized; 
	public ConversationData.ResponseNode[] responses; 
	public Vector2 nodePosition; 

	public string statement { get; }


	public string get_statement() { }

	public void .ctor() { }

}

