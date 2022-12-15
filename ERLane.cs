public struct ERLane // TypeDefIndex: 7235
{
	public float position;
	public ERLaneDirection direction;
	public ERDirectionType turnDirection;
	public int laneIndex;


	public void .ctor(float position, ERLaneDirection direction, int index) { }

	public void .ctor(ERLane lane) { }

	public void Copy(ERLane lane) { }

}

