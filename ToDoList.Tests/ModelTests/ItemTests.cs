using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
    [TestClass]
        public class ItemTest : IDisposable
    {
        public void Dispose()
    {
        Item.ClearAll();
    }

    [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
        public void GetDescription_ReturnsDescription_String()
    {
        string description = "Walk the Dad.";
        Item newItem = new Item(description);
        string result = newItem.GetDescription();
        Assert.AreEqual(description, result);
    }
    [TestMethod]
        public void SetDescription_SetDescription_String()
    {
        string description = "Walk the Dad.";
        Item newItem = new Item(description);
        string updatedDescription = "Duann do dishes.";
        newItem.SetDescription(updatedDescription);
        string result = newItem.GetDescription();
        Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
    {
        List<Item> newList = new List<Item> { };
        List<Item> result = Item.GetAll();

        CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnItems_ItemList()
    {
        string description01 = "Walk the Dad";
        string description02 = "Wash the Dad";
        Item newItem1 = new Item(description01);
        Item newItem2 = new Item(description02);
        List<Item> newList = new List<Item> {newItem1, newItem2};

        List<Item> result = Item.GetAll();

        CollectionAssert.AreEqual(newList, result);
    }
  }
}