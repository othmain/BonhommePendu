using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        // TODO: Compléter
        public GuessEvent(GameData gameData, char letter) {
            // TODO: Commencez par ICI
            this.Events = new List<GameEvent>();

            var guessedLetterEvent = new GuessedLetterEvent(gameData, letter);

            this.Events.Add(guessedLetterEvent);
        }
    }
}
