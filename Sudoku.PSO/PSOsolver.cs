using Sudoku.Shared;

namespace Sudoku.PSO
{
    public class PSOsolver : ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
            var tableau = s.Cells;
            // résoudre tableau
            return new() { Cells = tableau };
        }
    }
}
