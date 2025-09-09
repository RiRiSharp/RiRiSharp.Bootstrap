namespace RiRiSharp.Bootstrap.Components.Accordion.Internals;

public interface IHasCollapseState
{
    bool Collapsed { get; set; }
    void UpdateCollapseState(bool isCollapsed);
}
