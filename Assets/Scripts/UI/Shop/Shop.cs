using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject _grid;
    [SerializeField] private GameObject _itemPref;

    private GameObject _emptyCell;
    private List<GameObject> _towerList;

    void Start()
    {
        _towerList = glObjects.controllsGL.GetTowerList;
        CreateShopItem();

    }

    private void CreateShopItem()
    {
        for (int i = 0; i < _towerList.Count; i++)
        {
            GameObject item = Instantiate(_itemPref);
            item.GetComponent<ShopItem>().SetShopData(_towerList[i]);
            item.transform.SetParent(_grid.transform);
        }
    }

    public void BuyTower(GameObject prefab)
    {
        GameObject tower = Instantiate(prefab);
        tower.transform.SetParent(_emptyCell.transform);
        tower.transform.position = _emptyCell.transform.position;
        _emptyCell.GetComponent<EmptyCell>().SetStatus(false);
    }

    public void SetEmptyCell(GameObject cell)
    {
        _emptyCell = cell;
    }



}
