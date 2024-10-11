using BonhommePendu.Models;
using System.Diagnostics.Metrics;

namespace BonhommePendu.Events
{

    // Un événement à créer chaque fois que la lettre n'est pas dans le mot
    public class WrongGuessEvent : GameEvent
    {
        public char Letter { get; set; }
        // TODO: Compléter
        public WrongGuessEvent(GameData gameData, char letter) {
            this.Events = new List<GameEvent>();

            gameData.NbWrongGuesses++;


            
        }
    }
}
