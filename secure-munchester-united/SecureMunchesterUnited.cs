using System;

public class SecurityPassMaker
{

    private static readonly string Default = "Too Important for a Security Pass";
    private static readonly string Security = " Priority Personnel";

    public string GetDisplayName(TeamSupport support)
    {

        if(support == null){
            throw new ArgumentNullException("Support object must not be null");
        }

        if(support is Security && !(support is SecurityJunior || support is SecurityIntern ||support is PoliceLiaison) ){
            return support.Title + Security;
        }

        return support is Staff ? support.Title : Default;
    }
}

/**** Please do not alter the code below ****/

public interface TeamSupport { string Title { get; } }

public abstract class Staff : TeamSupport { public abstract string Title { get; } }

public class Manager : TeamSupport { public string Title { get; } = "The Manager"; }

public class Chairman : TeamSupport { public string Title { get; } = "The Chairman"; }

public class Physio : Staff { public override string Title { get; } = "The Physio"; }

public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }

public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }

public class Security : Staff { public override string Title { get; } = "Security Team Member"; }

public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }

public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }

public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }
