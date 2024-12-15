# 7 Boom Game

A fun and interactive **7 Boom** game built using Unity Engine. Test your reflexes and knowledge of numbers as you decide if the displayed number is a "Boom" or not. Perfect for casual gaming!

## Features
- Random number generation.
- Players must identify numbers divisible by 7 or containing the digit 7.
- Score tracking and mistake counter.
- Simple and intuitive UI.

### How to Play
1. A random number is displayed on the screen.
2. Decide if the number is "Boom" (divisible by 7 or contains the digit 7).
3. Click:
   - `Boom` if it matches the condition.
   - `Next` if it doesn't.
4. Earn points for correct answers; mistakes are tracked.
5. The game ends after 3 mistakes.

## Code Structure

### `GameManager.cs`
- Handles the game logic:
  - Random number generation.
  - Checking if the number is "Boom."
  - Updating score and mistake counters.
  - Ending the game after the maximum allowed mistakes.

### UI Elements
- **NumberText**: Displays the random number.
- **ScoreText**: Displays the player's current score.
- **MistakesText**: Displays the current number of mistakes.
- **BoomButton**: Button for selecting "Boom."
- **NotBoomButton**: Button for selecting "Not Boom."

### Future Features
- **Fruit Ninja Style Gameplay**: 
  - Display numbers on circle object flying across the screen.
  - Players swipe or click the fruits with numbers to identify "Boom" or "Not Boom."
  - Wrong swipes deduct points or add mistakes.
