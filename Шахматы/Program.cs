using Шахматы;

Console.WriteLine("Пешка");
Pawn pawn = new Pawn(1, 2);
Console.WriteLine(pawn.Step(1, 4));
Console.WriteLine(pawn.Step(1, 3));
Console.WriteLine(pawn.Step(1, 5));

Console.WriteLine("Ферзь");
Queen queen = new Queen(4, 4);
Console.WriteLine(queen.Step(3, 3));
Console.WriteLine(queen.Step(3, 4));
Console.WriteLine(queen.Step(5, 4));
Console.WriteLine(queen.Step(5, 3));
Console.WriteLine(queen.Step(3, 5));
Console.WriteLine(queen.Step(2, 6));
Console.WriteLine(queen.Step(2, 1));

Console.WriteLine("Ладья");
Rook rook = new Rook(4, 4);
Console.WriteLine(rook.Step(3, 4));
Console.WriteLine(rook.Step(5, 4));
Console.WriteLine(rook.Step(4, 5));
Console.WriteLine(rook.Step(4, 3));
Console.WriteLine(rook.Step(3, 3));

Console.WriteLine("Конь");
Knight knight = new Knight(4, 4);
Console.WriteLine(knight.Step(3, 2));
Console.WriteLine(knight.Step(3, 6));
Console.WriteLine(knight.Step(5, 2));
Console.WriteLine(knight.Step(1, 1));

Console.WriteLine("Король");
King king = new King(4, 4);
Console.WriteLine(king.Step(3, 4));
Console.WriteLine(king.Step(5, 4));
Console.WriteLine(king.Step(4, 5));
Console.WriteLine(king.Step(4, 3));
Console.WriteLine(king.Step(6, 4));

Console.WriteLine("Слон");
Bishop bishop =  new Bishop(4, 4);
Console.WriteLine(bishop.Step(3, 3));
Console.WriteLine(bishop.Step(2, 2));
Console.WriteLine(bishop.Step(5, 5));
Console.WriteLine(bishop.Step(3, 5));
Console.WriteLine(bishop.Step(5, 3));
Console.WriteLine(bishop.Step(2, 7));
