using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;

public class AnalyticsTracker : MonoBehaviour
{
    Dictionary<string, object>[] parameters = new Dictionary<string, object>[6]
    {
        new Dictionary<string, object>(),
        new Dictionary<string, object>(),
        new Dictionary<string, object>(),
        new Dictionary<string, object>(),
        new Dictionary<string, object>(),
        new Dictionary<string, object>()
    };

    private void Start()
    {
        parameters[0].Add("Africa_Exhibit", true);
        parameters[1].Add("Bear_Den_Exhibit", true);
        parameters[2].Add("Big_Cats_Exhibit", true);
        parameters[3].Add("Eagles_Nest_Exhibit", true);
        parameters[4].Add("Giant_Beasts_Exhibit", true);
        parameters[5].Add("Monkey_Habitat_Exhibit", true);
    }

    public void ExhibitVisitedAnalytics(int exhibitID)
    {
        Events.CustomData("exhibits_Visited", parameters[exhibitID]);
    }
}
