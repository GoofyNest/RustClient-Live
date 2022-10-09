public class AStarNode // TypeDefIndex: 13883
{
	public AStarNode Parent; 
	public float G; 
	public float H; 
	public BasePathNode Node; 

	public float F { get; }


	public float get_F() { }

	public void .ctor(float g, float h, AStarNode parent, BasePathNode node) { }

	public void Update(float g, float h, AStarNode parent, BasePathNode node) { }

	public bool Satisfies(BasePathNode node) { }

	public static bool op_LessThan(AStarNode lhs, AStarNode rhs) { }

	public static bool op_GreaterThan(AStarNode lhs, AStarNode rhs) { }

}

