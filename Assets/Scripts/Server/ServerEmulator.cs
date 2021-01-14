using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerEmulator : MonoBehaviour
{
    [SerializeField] private int _capacity;
    [SerializeField] private Item[] _items;
    [SerializeField] private Player[] _players;
    private List<Lot> _lots = new List<Lot>();

    public string GetLots()
    {
        for (int i = 0; i < _capacity - _lots.Count; i++)
        {
            int itemRange = Random.Range(0, _items.Length);

            int playerRange = Random.Range(0, _players.Length);
            Item newItem = new Item(_items[itemRange]);
            Lot lot = new Lot(newItem, _players[playerRange]);
            lot.Item.Count = Random.Range(1, 200);
            lot.Item.Moneys.Count = Random.Range(1, 20) * lot.Item.Count;
            _lots.Add(lot);
        }

        StockData data = new StockData(_lots);

        string jsonData = JsonUtility.ToJson(data);

        Debug.Log(jsonData);

        return jsonData;
    }
}

public struct StockData
{
    public Lot[] Lots;

    public StockData(List<Lot> lots)
    {
        Lots = lots.ToArray();
    }
}
