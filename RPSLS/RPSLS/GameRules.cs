namespace RPSLS.RPSLS;

public class GameRules
{
    public class RockRules : AbstractGameRules
    {
        public override PossibleResults Jokenpo(HandForm opponent)
        {
            return opponent switch
            {
                HandForm.Scissors => PossibleResults.Win,
                HandForm.Paper => PossibleResults.Lose,
                HandForm.Lizard => PossibleResults.Win,
                HandForm.Spock => PossibleResults.Lose,
                _ => PossibleResults.Tie
            };
        }
    }

    public class PaperRules : AbstractGameRules
    {
        public override PossibleResults Jokenpo(HandForm opponent)
        {
            return opponent switch
            {
                HandForm.Rock => PossibleResults.Win,
                HandForm.Scissors => PossibleResults.Lose,
                HandForm.Spock => PossibleResults.Win,
                HandForm.Lizard => PossibleResults.Lose,
                _ => PossibleResults.Tie
            };
        }
    }

    public class ScissorsRules : AbstractGameRules
    {
        public override PossibleResults Jokenpo(HandForm opponent)
        {
            return opponent switch
            {
                HandForm.Paper => PossibleResults.Win,
                HandForm.Rock => PossibleResults.Lose,
                HandForm.Lizard => PossibleResults.Win,
                HandForm.Spock => PossibleResults.Lose,
                _ => PossibleResults.Tie
            };
        }
    }

    public class LizardRules : AbstractGameRules
    {
        public override PossibleResults Jokenpo(HandForm opponent)
        {
            return opponent switch
            {
                HandForm.Paper => PossibleResults.Win,
                HandForm.Rock => PossibleResults.Lose,
                HandForm.Spock => PossibleResults.Win,
                HandForm.Scissors => PossibleResults.Lose,
                _ => PossibleResults.Tie
            };
        }
    }

    public class SpockRules : AbstractGameRules
    {
        public override PossibleResults Jokenpo(HandForm opponent)
        {
            return opponent switch
            {
                HandForm.Scissors => PossibleResults.Win,
                HandForm.Paper => PossibleResults.Lose,
                HandForm.Rock => PossibleResults.Win,
                HandForm.Lizard => PossibleResults.Lose,
                _ => PossibleResults.Tie
            };
        }
    }
}