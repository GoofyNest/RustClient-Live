public class ConversationData : ScriptableObject // TypeDefIndex: 8840
{	// Fields
	public string shortname; // 0x18
	public Translate.Phrase providerNameTranslated; // 0x20
	public ConversationData.SpeechNode[] speeches; // 0x28

	// Properties
	public string providerName { get; }

	// Methods

	// RVA: 0x516210 Offset: 0x515610 VA: 0x180516210
	public string get_providerName() { }

	// RVA: 0x516160 Offset: 0x515560 VA: 0x180516160
	public int GetSpeechNodeIndex(string speechShortName) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class ConversationData.ConversationCondition // TypeDefIndex: 8841
{	// Fields
	public ConversationData.ConversationCondition.ConditionType conditionType; // 0x10
	public uint conditionAmount; // 0x14
	public bool inverse; // 0x18
	public string failedSpeechNode; // 0x20

	// Methods

	// RVA: 0x516000 Offset: 0x515400 VA: 0x180516000
	public bool Passes(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum ConversationData.ConversationCondition.ConditionType // TypeDefIndex: 8842
{	// Fields
	public int value__; // 0x0
	public const ConversationData.ConversationCondition.ConditionType NONE = 0;
	public const ConversationData.ConversationCondition.ConditionType HASHEALTH = 1;
	public const ConversationData.ConversationCondition.ConditionType HASSCRAP = 2;
	public const ConversationData.ConversationCondition.ConditionType PROVIDERBUSY = 3;
	public const ConversationData.ConversationCondition.ConditionType MISSIONCOMPLETE = 4;
	public const ConversationData.ConversationCondition.ConditionType MISSIONATTEMPTED = 5;
	public const ConversationData.ConversationCondition.ConditionType CANACCEPT = 6;

}

public class ConversationData.ResponseNode // TypeDefIndex: 8843
{	// Fields
	public Translate.Phrase responseTextLocalized; // 0x10
	public ConversationData.ConversationCondition[] conditions; // 0x18
	public string actionString; // 0x20
	public string resultingSpeechNode; // 0x28

	// Properties
	public string responseText { get; }

	// Methods

	// RVA: 0x5251D0 Offset: 0x5245D0 VA: 0x1805251D0
	public string get_responseText() { }

	// RVA: 0x524FF0 Offset: 0x5243F0 VA: 0x180524FF0
	public bool PassesConditions(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x524DF0 Offset: 0x5241F0 VA: 0x180524DF0
	public string GetFailedSpeechNode(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ConversationData.SpeechNode // TypeDefIndex: 8844
{	// Fields
	public string shortname; // 0x10
	public Translate.Phrase statementLocalized; // 0x18
	public ConversationData.ResponseNode[] responses; // 0x20
	public Vector2 nodePosition; // 0x28

	// Properties
	public string statement { get; }

	// Methods

	// RVA: 0x525200 Offset: 0x524600 VA: 0x180525200
	public string get_statement() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

