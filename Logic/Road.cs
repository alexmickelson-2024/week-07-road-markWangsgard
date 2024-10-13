public class Road : IRoad
{
    public int RowCount { get; }
    public int ColCount { get; }
    private IVehicle[,] roadTable {get; set;}
    public void SetVehicle(int row, int column, IVehicle vehicle)
    {
        roadTable[row - 1,column - 1] = vehicle;
    }
    public IVehicle? GetVehicle(int row, int column)
    {
        return roadTable[row, column];
    }
    public Road(int numberOfRows, int numberOfColumns)
    {
        RowCount = numberOfRows;
        ColCount = numberOfColumns;
        roadTable = new IVehicle[RowCount, ColCount];
    }
}