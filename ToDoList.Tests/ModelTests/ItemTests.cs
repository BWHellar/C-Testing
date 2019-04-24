using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {

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
  }
}