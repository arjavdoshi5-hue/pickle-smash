# Pickle Smash - Game Design Document (GDD)

## 1. Overview
**Pickle Smash** is a realistic 3D mobile pickleball game. Players compete in global trophy leagues, using intuitive swipe-to-hit controls to dominate the court. The game features a loot-box economy where players unlock new paddles, gear, and upgrades through reward bags.

## 2. Core Swipe Controls
The primary interaction mechanism is swipe-based, allowing for intuitive and realistic shot making:

*   **Dink**: A short, soft swipe upwards. Used to drop the ball gently over the net into the opponent's Kitchen.
*   **Drive**: A fast, straight swipe forward. Used for powerful, flat shots aimed deep into the opponent's court.
*   **Lob**: A long, slow swipe upwards. Used to hit the ball high over the opponent's head, forcing them to retreat to the baseline.
*   **Smash**: A sharp, fast swipe downwards when the ball is high in the air. Used to finish the point with a powerful, unreturnable shot.

## 3. Gameplay Mechanics: The 'Kitchen' Rule
The "Kitchen" (Non-Volley Zone) is a 7-foot area on both sides of the net.
*   **Rule**: A player cannot hit a volley (hitting the ball before it bounces) while standing inside the Kitchen or touching the Kitchen line.
*   **Implementation**: If a player's avatar is positioned in the Kitchen, the game will restrict the ability to hit a smash or volley drive. The player must let the ball bounce first. Stepping into the Kitchen to hit a volley will result in an immediate fault and loss of the point.

## 4. Economy Loop
The progression system relies on competitive play and a structured reward loop:

### 4.1. Trophies & Global Leagues
*   **Earning Trophies**: Players win Trophies by winning matches against other players.
*   **Losing Trophies**: Losing a match results in a deduction of Trophies.
*   **League System**: Trophies determine a player's rank in the Global Trophy League (e.g., Bronze, Silver, Gold, Platinum). Higher leagues offer better passive rewards and tougher competition.

### 4.2. Reward Bags (Loot-boxes)
*   **Acquisition**: Winning matches rewards players with Reward Bags. Players have a limited number of slots (e.g., 4 slots) to hold bags.
*   **Unlocking**: Bags take time to unlock (e.g., 3 hours for a Basic Bag, 8 hours for a Premium Bag). Players can use premium currency to skip the wait time.
*   **Contents**: Once opened, bags reward:
    *   **Coins**: Soft currency used for upgrading gear.
    *   **Gear Cards**: Duplicate cards of paddles, shoes, and grips. Collecting enough cards allows the player to upgrade that specific piece of gear, improving their in-game stats (e.g., power, control, spin).

## 5. Future Expansion
*   Tournaments and special events.
*   Customizable player avatars.
*   Social features (Guilds/Clubs).
