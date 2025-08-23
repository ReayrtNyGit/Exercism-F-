module QueenAttack

// Validate if a queen position is valid (on the board)
let create (row, col) =
    row >= 0 && row < 8 && col >= 0 && col < 8

// Check if two queens can attack each other
let canAttack (queen1Row, queen1Col) (queen2Row, queen2Col) =
    // First validate both positions
    if not (create (queen1Row, queen1Col)) || not (create (queen2Row, queen2Col)) then
        false
    else
        // Check if they can attack: same row, same column, or same diagonal
        queen1Row = queen2Row || 
        queen1Col = queen2Col || 
        abs (queen1Row - queen2Row) = abs (queen1Col - queen2Col)