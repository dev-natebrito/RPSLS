namespace RPSLS.RPSLS;

public enum HandForm
{
    Rock,
    Paper,
    Scissors,
    Lizard,
    Spock
}

public static class HandForms
{
    public static AbstractGameRules RuleSelector(this HandForm handForm)
    {
        switch (handForm)
        {
            case HandForm.Rock:
                return new GameRules.RockRules();
            case HandForm.Paper:
                return new GameRules.PaperRules();
            case HandForm.Scissors:
                return new GameRules.ScissorsRules();
            case HandForm.Lizard:
                return new GameRules.LizardRules();
            case HandForm.Spock:
                return new GameRules.SpockRules();

            default: throw new ArgumentException("There is no rule for this hand form");
        }
    }
}