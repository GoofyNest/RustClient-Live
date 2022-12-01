public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 4971
{
	[SerializeField]
	protected GridLayoutGroup.Corner m_StartCorner;
	[SerializeField]
	protected GridLayoutGroup.Axis m_StartAxis;
	[SerializeField]
	protected Vector2 m_CellSize;
	[SerializeField]
	protected Vector2 m_Spacing;
	[SerializeField]
	protected GridLayoutGroup.Constraint m_Constraint;
	[SerializeField]
	protected int m_ConstraintCount;

	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }


	public GridLayoutGroup.Corner get_startCorner() { }

	public void set_startCorner(GridLayoutGroup.Corner value) { }

	public GridLayoutGroup.Axis get_startAxis() { }

	public void set_startAxis(GridLayoutGroup.Axis value) { }

	public Vector2 get_cellSize() { }

	public void set_cellSize(Vector2 value) { }

	public Vector2 get_spacing() { }

	public void set_spacing(Vector2 value) { }

	public GridLayoutGroup.Constraint get_constraint() { }

	public void set_constraint(GridLayoutGroup.Constraint value) { }

	public int get_constraintCount() { }

	public void set_constraintCount(int value) { }

	protected void .ctor() { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	public override void SetLayoutHorizontal() { }

	public override void SetLayoutVertical() { }

	private void SetCellsAlongAxis(int axis) { }

}

public enum GridLayoutGroup.Corner // TypeDefIndex: 4972
{
	public int value__;
	public const GridLayoutGroup.Corner UpperLeft = 0;
	public const GridLayoutGroup.Corner UpperRight = 1;
	public const GridLayoutGroup.Corner LowerLeft = 2;
	public const GridLayoutGroup.Corner LowerRight = 3;

}

public enum GridLayoutGroup.Axis // TypeDefIndex: 4973
{
	public int value__;
	public const GridLayoutGroup.Axis Horizontal = 0;
	public const GridLayoutGroup.Axis Vertical = 1;

}

public enum GridLayoutGroup.Constraint // TypeDefIndex: 4974
{
	public int value__;
	public const GridLayoutGroup.Constraint Flexible = 0;
	public const GridLayoutGroup.Constraint FixedColumnCount = 1;
	public const GridLayoutGroup.Constraint FixedRowCount = 2;

}

