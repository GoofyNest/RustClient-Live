public class AStarNode // TypeDefIndex: 12142
{	public AStarNode Parent; // 0x10
	public float G; // 0x18
	public float H; // 0x1C
	public BasePathNode Node; // 0x20

	public float F { get; }


	public float get_F() { }

	public void .ctor(float g, float h, AStarNode parent, BasePathNode node) { }

	public void Update(float g, float h, AStarNode parent, BasePathNode node) { }

	public bool Satisfies(BasePathNode node) { }

	public static bool op_LessThan(AStarNode lhs, AStarNode rhs) { }

	public static bool op_GreaterThan(AStarNode lhs, AStarNode rhs) { }

}

