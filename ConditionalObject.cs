public class ConditionalObject // TypeDefIndex: 12092
{	public GameObject gameObject; // 0x10
	public GameObject ownerGameObject; // 0x18
	public ConditionalSocketSettings[] socketSettings; // 0x20
	public bool restrictOnHealth; // 0x28
	public float healthRestrictionMin; // 0x2C
	public float healthRestrictionMax; // 0x30
	public bool restrictOnAdjacent; // 0x34
	public ConditionalObject.AdjacentCondition adjacentRestriction; // 0x38
	public ConditionalObject.AdjacentMatchType adjacentMatch; // 0x3C
	public bool restrictOnLockable; // 0x40
	public bool lockableRestriction; // 0x41
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<bool> <IsActive>k__BackingField; // 0x42

	public Nullable<bool> IsActive { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Nullable<bool> get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsActive(Nullable<bool> value) { }

	public void .ctor(GameObject conditionalGO, GameObject ownerGO, int socketsTaken) { }

	public void SetActive(bool active) { }

	public void RefreshActive() { }

}

public enum ConditionalObject.AdjacentCondition // TypeDefIndex: 12093
{	public int value__; // 0x0
	public const ConditionalObject.AdjacentCondition SameInFront = 0;
	public const ConditionalObject.AdjacentCondition SameBehind = 1;
	public const ConditionalObject.AdjacentCondition DifferentInFront = 2;
	public const ConditionalObject.AdjacentCondition DifferentBehind = 3;
	public const ConditionalObject.AdjacentCondition BothDifferent = 4;
	public const ConditionalObject.AdjacentCondition BothSame = 5;

}

public enum ConditionalObject.AdjacentMatchType // TypeDefIndex: 12094
{	public int value__; // 0x0
	public const ConditionalObject.AdjacentMatchType GroupOrExact = 0;
	public const ConditionalObject.AdjacentMatchType ExactOnly = 1;
	public const ConditionalObject.AdjacentMatchType GroupNotExact = 2;

}

