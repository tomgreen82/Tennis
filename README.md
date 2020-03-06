## About this Kata

- Test Driven Development
- C#

This Kata is about implementing a simple tennis game where it has been simplified, so each set is one game.

The scoring system is rather simple:

1. Each player can have either of these points in one game 0 15 30 40
2. If you have 40 and you win the ball you win the game, however there are special rules.
3. If both have 40 the players are deuce. a. If the game is in deuce, the winner of a ball will have advantage and game ball. b. If the player with advantage wins the ball he wins the game c. If the player without advantage wins they are back at deuce.

===== Alternate description of the rules per Wikipedia ( http://en.wikipedia.org/wiki/Tennis#Scoring ):

1. A game is won by the first player to have won at least four points in total and at least two points more than the opponent.

2. The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as “love”, “fifteen”, “thirty”, and “forty” respectively.

3. If at least three points have been scored by each player, and the scores are equal, the score is “deuce”.

4. If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is “advantage” for the player in the lead.

## User Stories
**The one a player has not scored any points** </br>
Given a player has a score of zero </br>
When the score is printed </br>
Then the score to be returned as "love" </br>

**The one where the player has scored one point** </br>
Given a player has a score of one </br>
When the score is printed </br>
Then the score to be returned as "fifteen" </br>

**The one where the player has scored two points** </br>
Given a player has a score of two </br>
When the score is printed </br>
Then the score to be returned as "thirty" </br>

**The one where the player has scored three points** </br>
Given a player has a score of three </br>
When the score is printed </br>
Then the score to be returned as "forty" </br>

**The one where the score of a game is printed in the correct format** </br>
Given a game exists </br>
When both players have a score </br>
Then the score to be printed in the format "playerOneScore : playerTwoScore" </br>

**The one where a deuce occurs** </br>
Given a game exists </br>
And both players have 3 or more points </br>
When both players points are equal </br>
Then the score to be printed in the format "deuce" </br>

**The one where an advantage occurs** </br>
Given a game exists </br>
And both players have 3 or more points </br>
When one player has a score of the other +1 </br>
Then the score to be printed in the format "advantage playerName" </br>

**The one where a player wins** </br>
Given a game exists </br>
And both players have 3 or more points </br>
When player has a score of more than 3 and the score is gearter than the other players score by 2</br>
Then the score to be printed in the format "playerName Wins!" </br>

