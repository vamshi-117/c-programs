using System;
public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }
    public int Row { get; }
    public int Column { get; }
}
public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        int rowdiff = white.Row - black.Row;
        if (rowdiff == 0)
            return true;
        int coldiff = white.Column - black.Column;
        if (coldiff == 0)
            return true;
        if (Math.Abs(rowdiff) == Math.Abs(coldiff))
            return true;
        return false;
    }
    public static Queen Create(int row, int column)
    {
        if (row < 0 || row >= 8)
            throw new ArgumentOutOfRangeException();
        if (column < 0 || column >= 8)
            throw new ArgumentOutOfRangeException();
        return new Queen(row, column);
    }
}