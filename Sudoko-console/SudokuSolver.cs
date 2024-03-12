namespace Sudoku
{
    internal class SudokuSolver
    {
        public void printSudoku(int[,] sudokuveld)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"{sudokuveld[i, j]}   ");
                }
                Console.WriteLine();
            }
        }

        public bool losOp(int[,] sudokuveld)
        {
            for (int rij = 0; rij<9 ; rij++)
            { 
                for (int kolom = 0; kolom < 9 ; kolom++)
                {
                    if (sudokuveld[rij, kolom] == 0)
                    {
                        for (int waarde = 1; waarde <= 9; waarde++)
                        {
                            if (isAllesGeldig(rij, kolom, waarde, sudokuveld))
                            {
                                sudokuveld[rij, kolom] = waarde;

                                if (losOp(sudokuveld))
                                {
                                    return true;
                                }
                                else
                                {
                                    sudokuveld[rij, kolom] = 0;
                                }
                            }
                        }
                        return false;
                    }

                }
            }

            return true;
        }



        public bool isAllesGeldig(int rij, int kol, int waarde, int[,] sudokuveld)
        {
            if (isRijGeldig(rij, waarde, sudokuveld)
                && isKolomGeldig(kol, waarde, sudokuveld)
                && isCelGeldig(rij, kol, waarde, sudokuveld)) { return true; }
            return false;
        }
        
        // controleer of een rij geldig is wanneer we een waarde toevoegen
        // rij: rij-index
        // waarde: in te vullen waarde
        // sudokuveld: 2d array die de sudoku beschrijft
        private bool isRijGeldig(int rij, int waarde, int[,] sudokuveld)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudokuveld[rij, i] == waarde)
                    return false;
            }
            return true;
        }

        // controleer of een kolom geldig is wanneer we een waarde toevoegen
        // kolom: kolom-index
        // waarde: in te vullen waarde
        // sudokuveld: 2d array die de sudoku beschrijft
        private bool isKolomGeldig(int kol, int waarde, int[,] sudokuveld)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudokuveld[i, kol] == waarde)
                    return false;
            }
            return true;
        }
        private bool isCelGeldig(int rij, int kol, int waarde, int[,] sudokuveld)
        {
            int startRij = (rij / 3) * 3;
            int startKol = (kol / 3) * 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (sudokuveld[startRij+i,startKol+j] == waarde)
                        return false;
                }
            }

            return true;
        }
    }
}
