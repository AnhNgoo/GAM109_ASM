using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Threading;

public class ASM_MN : Singleton<ASM_MN>
{
    public List<Region> listRegion = new List<Region>();
    public List<Players> listPlayer = new List<Players>();

    private void Start()
    {
        createRegion();
    }

    public void createRegion()
    {
        listRegion.Add(new Region(0, "VN"));
        listRegion.Add(new Region(1, "VN1"));
        listRegion.Add(new Region(2, "VN2"));
        listRegion.Add(new Region(3, "JS"));
        listRegion.Add(new Region(4, "VS"));
    }

    public string calculate_rank(int score) =>
        score >= 1000 ? "Kim cương" :
        score >= 500 ? "Vàng" :
        score >= 100 ? "Bạc" : "Hạng đồng";

    public void YC1(int ID, int score, string userName, Region IDregion) =>
        listPlayer.Add(new Players(ID, score, userName, IDregion));
    public void YC2()
    {
        Debug.Log("----------------------------------------------------------------------------------------------------------------------------------------------------");
        Debug.Log("Danh Sách Toàn Bộ Người Chơi: ");
        listPlayer.ForEach(player =>
        {
            Debug.Log($"ID: {player.ID}, Name: {player.userName}, Score: {player.score}, Region: {player.IDregion.Name}, Rank: {calculate_rank(player.score)}");
        });
        Debug.Log("----------------------------------------------------------------------------------------------------------------------------------------------------");
    }
    public void YC3()
    {
            if (listPlayer.Count == 0)
        {
            Debug.Log("Không có người chơi nào trong danh sách.");
            return;
        }

        Players currentPlayer = listPlayer.Last();

        var lowerScorePlayers = listPlayer
            .Where(p => p.score < currentPlayer.score)
            .ToList();

        Debug.Log($"Người chơi hiện tại: {currentPlayer.userName} - Score: {currentPlayer.score}");
        Debug.Log("Danh sách người chơi có score bé hơn:");

        if (lowerScorePlayers.Count == 0)
            Debug.Log("Không có người chơi nào có điểm nhỏ hơn người chơi hiện tại");
        else
            lowerScorePlayers.ForEach(player =>
                Debug.Log($"ID: {player.ID}, Name: {player.userName}, Score: {player.score}, Region: {player.IDregion.Name}, Rank: {calculate_rank(player.score)}")
            );
    }
    public void YC4()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC5()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC6()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC7()
    {
        // sinh viên viết tiếp code ở đây
    }
    void CalculateAndSaveAverageScoreByRegion()
    {
        // sinh viên viết tiếp code ở đây
    }

}

[SerializeField]
public class Region
{
    public int ID;
    public string Name;
    public Region(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
}

[SerializeField]
public class Players
{
    public int ID;
    public int score;
    public string userName;
    public Region IDregion;

    public Players(int ID, int score, string userName, Region IDregion)
    {
        this.ID =  ID;
        this.score  = score;
        this.userName = userName;

        this.IDregion = IDregion;
    }
}