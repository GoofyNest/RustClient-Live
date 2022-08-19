public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 4965
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected GridLayoutGroup.Corner m_StartCorner; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected GridLayoutGroup.Axis m_StartAxis; // 0x5C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Vector2 m_CellSize; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Vector2 m_Spacing; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected GridLayoutGroup.Constraint m_Constraint; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_ConstraintCount; // 0x74

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x15EBD70 Offset: 0x15EB170 VA: 0x1815EBD70
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x15EBD20 Offset: 0x15EB120 VA: 0x1815EBD20
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x15EBB70 Offset: 0x15EAF70 VA: 0x1815EBB70
	public Vector2 get_cellSize() { }

	// RVA: 0x15EBBB0 Offset: 0x15EAFB0 VA: 0x1815EBBB0
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x15EBB90 Offset: 0x15EAF90 VA: 0x1815EBB90
	public Vector2 get_spacing() { }

	// RVA: 0x15EBCD0 Offset: 0x15EB0D0 VA: 0x1815EBCD0
	public void set_spacing(Vector2 value) { }

	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x15EBC80 Offset: 0x15EB080 VA: 0x1815EBC80
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0xB24340 Offset: 0xB23740 VA: 0x180B24340
	public int get_constraintCount() { }

	// RVA: 0x15EBC00 Offset: 0x15EB000 VA: 0x1815EBC00
	public void set_constraintCount(int value) { }

	// RVA: 0x15EBAC0 Offset: 0x15EAEC0 VA: 0x1815EBAC0
	protected void .ctor() { }

	// RVA: 0x15EAF90 Offset: 0x15EA390 VA: 0x1815EAF90 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15EB150 Offset: 0x15EA550 VA: 0x1815EB150 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x15EBAA0 Offset: 0x15EAEA0 VA: 0x1815EBAA0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x15EBAB0 Offset: 0x15EAEB0 VA: 0x1815EBAB0 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x15EB370 Offset: 0x15EA770 VA: 0x1815EB370
	private void SetCellsAlongAxis(int axis) { }

}

public enum GridLayoutGroup.Corner // TypeDefIndex: 4966
{	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Corner UpperLeft = 0;
	public const GridLayoutGroup.Corner UpperRight = 1;
	public const GridLayoutGroup.Corner LowerLeft = 2;
	public const GridLayoutGroup.Corner LowerRight = 3;

}

public enum GridLayoutGroup.Axis // TypeDefIndex: 4967
{	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Axis Horizontal = 0;
	public const GridLayoutGroup.Axis Vertical = 1;

}

public enum GridLayoutGroup.Constraint // TypeDefIndex: 4968
{	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Constraint Flexible = 0;
	public const GridLayoutGroup.Constraint FixedColumnCount = 1;
	public const GridLayoutGroup.Constraint FixedRowCount = 2;

}

