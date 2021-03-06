using Innovator.Client;
using System;

namespace Innovator.Client.Model
{
  ///<summary>Class for the item type Activity Template Transition </summary>
  [ArasName("Activity Template Transition")]
  public class ActivityTemplateTransition : Item, INullRelationship<ActivityTemplate>, IRelationship<LifeCycleTransition>
  {
    protected ActivityTemplateTransition() { }
    public ActivityTemplateTransition(ElementFactory amlContext, params object[] content) : base(amlContext, content) { }
    static ActivityTemplateTransition() { Innovator.Client.Item.AddNullItem<ActivityTemplateTransition>(new ActivityTemplateTransition { _attr = ElementAttributes.ReadOnly | ElementAttributes.Null }); }

    /// <summary>Retrieve the <c>behavior</c> property of the item</summary>
    [ArasName("behavior")]
    public IProperty_Text Behavior()
    {
      return this.Property("behavior");
    }
    /// <summary>Retrieve the <c>controlled_itemtype</c> property of the item</summary>
    [ArasName("controlled_itemtype")]
    public IProperty_Item<ItemType> ControlledItemtype()
    {
      return this.Property("controlled_itemtype");
    }
    /// <summary>Retrieve the <c>event</c> property of the item</summary>
    [ArasName("event")]
    public IProperty_Text Event()
    {
      return this.Property("event");
    }
    /// <summary>Retrieve the <c>sort_order</c> property of the item</summary>
    [ArasName("sort_order")]
    public IProperty_Number SortOrder()
    {
      return this.Property("sort_order");
    }
  }
}