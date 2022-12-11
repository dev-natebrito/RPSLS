namespace RPSLS.RPSLS;

public class Jokenpo
{
    public PossibleResults PlayGame(Player p1, Player p2)
    {
        return p1.HandForm.RuleSelector().Jokenpo(p2.HandForm);
    }
}