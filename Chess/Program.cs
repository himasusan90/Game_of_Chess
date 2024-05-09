using Chess;

var player1 = new Player("Alice", Color.White);
var player2 = new Player("Bob", Color.Black);
var game = new Game(player1, player2);
game.PrintBoard();
// Example move (assuming you handle input and validation elsewhere)
game.MakeMove(1, 1, 1, 2);  // Move player's piece from (1,0) to (1,2)
game.PrintBoard();
