public class ConditionalObject // TypeDefIndex: 13833
{
	public GameObject gameObject; 
	public GameObject ownerGameObject; 
	public ConditionalSocketSettings[] socketSettings; 
	public bool restrictOnHealth; 
	public float healthRestrictionMin; 
	public float healthRestrictionMax; 
	public bool restrictOnAdjacent; 
	public ConditionalObject.AdjacentCondition adjacentRestriction; 
	public ConditionalObject.AdjacentMatchType adjacentMatch; 
	public bool restrictOnLockable; 
	public bool lockableRestriction; 
	[CompilerGeneratedAttribute] 
	private Nullable<bool> <IsActive>k__BackingField; 

	public Nullable<bool> IsActive { get; set; }


	[CompilerGeneratedAttribute] 
	public Nullable<bool> get_IsActive() { }

	[CompilerGeneratedAttribute] 
	private void set_IsActive(Nullable<bool> value) { }

	public void .ctor(GameObject conditionalGO, GameObject ownerGO, int socketsTaken) { }

	public void SetActive(bool active) { }

	public void RefreshActive() { }

}

public enum ConditionalObject.AdjacentCondition // TypeDefIndex: 13834
{
	public int value__; 
	public const ConditionalObject.AdjacentCondition SameInFront = 0;
	public const ConditionalObject.AdjacentCondition SameBehind = 1;
	public const ConditionalObject.AdjacentCondition DifferentInFront = 2;
	public const ConditionalObject.AdjacentCondition DifferentBehind = 3;
	public const ConditionalObject.AdjacentCondition BothDifferent = 4;
	public const ConditionalObject.AdjacentCondition BothSame = 5;

}

public enum ConditionalObject.AdjacentMatchType // TypeDefIndex: 13835
{
	public int value__; 
	public const ConditionalObject.AdjacentMatchType GroupOrExact = 0;
	public const ConditionalObject.AdjacentMatchType ExactOnly = 1;
	public const ConditionalObject.AdjacentMatchType GroupNotExact = 2;

}

