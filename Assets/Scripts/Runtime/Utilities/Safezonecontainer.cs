using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Safezonecontainer : VisualElement
{
    public new class UxmlFactory : UxmlFactory<Safezonecontainer, VisualElement.UxmlTraits> { }

    public Safezonecontainer()
    {
        style.flexGrow = 1;
        style.flexShrink = 1;
        RegisterCallback<GeometryChangedEvent>(LayoutChanged);
    }

    private void LayoutChanged(GeometryChangedEvent e)
    {
        Rect safeArea = Screen.safeArea;

        try
        {
            Vector2 leftTop = RuntimePanelUtils.ScreenToPanel(panel,
                    new Vector2(safeArea.xMin, Screen.height - safeArea.yMax));
            Vector2 rightBottom = RuntimePanelUtils.ScreenToPanel(panel,
                    new Vector2(Screen.width - safeArea.xMax, safeArea.yMin));

            style.marginLeft = leftTop.x;
            style.marginTop = leftTop.y;
            style.marginRight = rightBottom.x;
            style.marginBottom = rightBottom.y;
        }
        catch (InvalidCastException) { }
    }
}