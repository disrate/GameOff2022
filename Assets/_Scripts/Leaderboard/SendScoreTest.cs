using UnityEngine;
using LootLocker.Requests;

public class SendScoreTest : MonoBehaviour
{
    public void SubmitHighscore()
    {
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                if (GlobalPlayerName.playerName == null) return;
                string memberID = GlobalPlayerName.playerName;
                int leaderboardID = GlobalPlayerName.leaderboardID;
                int score = Random.Range(1,10);

                LootLockerSDKManager.SubmitScore(memberID, score, leaderboardID, (response) =>
                {
                    if (response.statusCode == 200)
                    {
                        Debug.Log("Successful");
                    }
                    else
                    {
                        Debug.Log("failed: " + response.Error);
                    }
                });
            }
        });
    }
}
